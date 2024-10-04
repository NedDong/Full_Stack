

--1) 

SELECT DISTINCT c.City
FROM Customers c cross join Employees e
Where c.City = e.City

--2)
--sub-query
SELECT DISTINCT c.city
From Customers c
Where c.city not
in
(
SELECT DISTINCT e.City
FROM Employees e
)
--no-sub-query
SELECT DISTINCT c.city
FROM Customers c left join Employees e on c.City = e.City
Where e.city is null

--3) 

Select p.ProductName, SUM(od.Quantity) as [total order quantities]
from [Order Details] od left join Products p on od.ProductID = p.ProductID
Group by p.ProductID, p.ProductName

--4)

select c.city, sum(od.quantity)
from Customers c join Orders o on c.customerID = o.CustomerID join [Order Details] od on o.orderID = od.orderID
Group by c.city

--5) 

select c.city, count(c.customerID)
from Customers c
group by c.City
having count(customerID) >= 2

--6)

select c.city
from Customers c join Orders o on c.customerID = o.CustomerID join [Order Details] od on o.orderID = od.orderID
Group by c.city
having count(od.ProductID) > 2

--7)

select distinct c.customerID, c.city, o.ShipCity
from customers c left join orders o on c.customerid = o.customerid
where c.city != o.shipcity

--8)

with mostAmount as
(
select top 1 c.city as ECity, SUM(od.quantity) as test1
from Customers c join Orders o on c.customerID = o.CustomerID join [Order Details] od on o.orderID = od.orderID
Group by c.city
order by SUM(od.quantity) desc
), soldmost as (
select top 1 e.city as CCity
from Orders o left join Employees e on o.EmployeeID = e.EmployeeID
group by e.city
order by count(*) DESC
)
select m.ECity
from mostAmount m join soldmost s on m.ECity = s.CCity


--9)
--no-sub-query
select e.City
from Employees e left join orders o on e.employeeid = o.employeeid
where o.orderid is NULL
group by e.city
--sub-query

SELECT DISTINCT e.city
FROM Employees e
Where e.city not in
(
    SELECT DISTINCT o.ShipCity
    FROM Orders o
)


--10)

with mostAmount as
(
select top 1 c.city as ECity, SUM(od.quantity) as test1
from Customers c join Orders o on c.customerID = o.CustomerID join [Order Details] od on o.orderID = od.orderID
Group by c.city
order by SUM(od.quantity) desc
), soldmost as (
select top 1 e.city as CCity
from Orders o left join Employees e on o.EmployeeID = e.EmployeeID
group by e.city
order by count(*) DESC
)
select m.ECity
from mostAmount m join soldmost s on m.ECity = s.CCity


--11)

I would first select all data columns from table, and group by all data columns. 
If the grouped entries has a count of more than 1, which means the entries are all the same on all columns, 
then i would delete those idenified entries.
This could be changed if there is a primary key or unique field, i would choose columns accordingly.
