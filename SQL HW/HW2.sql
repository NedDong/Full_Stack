
--1)

Select Count(*) as Count
From Production.Product

--2)

Select Count(*) as Count
From Production.Product as p
Where p.ProductSubcategoryID is not null

--3)

Select p.ProductSubcategoryID as ProductSubcategoryID, Count(*) as CountedProducts
From Production.Product as p
Where p.ProductSubcategoryID is not null
Group by p.ProductSubcategoryID

--4)

Select Count(*) as Count
From Production.Product as p
Where p.ProductSubcategoryID is null

--5) Write a query to list the sum of products quantity of each product in the Production.ProductInventory table.

select p.ProductID, SUM(p.Quantity) as 'sum of products quantity'
from Production.ProductInventory as p
group by p.ProductID

--6) Write a query to list the sum of products in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100.

select p.ProductID, SUM(p.Quantity) as 'The Sum'
from Production.ProductInventory as p
where p.LocationID = 40
group by p.ProductID
having SUM(p.Quantity) < 100

--7) Write a query to list the sum of products with the shelf information in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100

select p.Shelf as Shelf, p.ProductID, SUM(p.Quantity) as 'The Sum'
from Production.ProductInventory as p
where p.LocationID = 40
group by p.ProductID, p.Shelf
having SUM(p.Quantity) < 100

--8) Write the query to list the average quantity for products where column LocationID has the value of 10 from the table Production.ProductInventory table.

select p.ProductID, avg(p.Quantity) as 'TheAvg'
from Production.ProductInventory as p
where p.LocationID = 10
group by p.ProductID

--9) Write query  to see the average quantity  of  products by shelf  from the table Production.ProductInventory

select p.ProductID, p.Shelf as Shelf, avg(p.Quantity) as 'TheAvg'
from Production.ProductInventory as p
where p.LocationID = 10
group by p.ProductID, p.Shelf

--10) Write query  to see the average quantity  of  products by shelf excluding rows that has the value of N/A in the column Shelf from the table Production.ProductInventory

select p.ProductID, p.Shelf as Shelf, avg(p.Quantity) as 'TheAvg'
from Production.ProductInventory as p
where p.LocationID = 10 and p.Shelf != 'N/A'
group by p.ProductID, p.Shelf

--11) List the members (rows) and average list price in the Production.Product table. This should be grouped independently over the Color and the Class column. Exclude the rows where Color or Class are null.

select p.Color, p.Class, count(*) as TheCount, avg(p.ListPrice) as AvgPrice
from Production.Product as p
where p.Color is not null and p.Class is not null
group by p.Color, p.Class

--12) Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables. Join them and produce a result set similar to the following.

SELECT c.Name as Country, s.Name as Province
FROM Person.CountryRegion c JOIN Person.StateProvince s on c.CountryRegionCode = s.CountryRegionCode

--13) Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables and list the countries filter them by Germany and Canada. Join them and produce a result set similar to the following.

SELECT c.Name as Country, s.Name as Province
FROM Person.CountryRegion c JOIN Person.StateProvince s on c.CountryRegionCode = s.CountryRegionCode
Where c.Name = 'Germany' or c.Name = 'Canada'

--14)  List all Products that has been sold at least once in last 27 years.

SELECT od.ProductID
FROM "Order Details" od left join Orders o on od.OrderID = o.OrderID
Where o.OrderDate > DATEADD(year, -27, GetDate())
Group by od.ProductID
Having SUM(od.Quantity) > 1 --This line is not required, but added for logic reason
Order by od.ProductID ASC

--15) List top 5 locations (Zip Code) where the products sold most.

SELECT TOP 5 o.ShipPostalCode, SUM(od.Quantity)
FROM "Order Details" od left join Orders o on od.OrderID = o.OrderID
GROUP by o.ShipPostalCode
Having o.ShipPostalCode is not NULL
Order By SUM(od.Quantity) DESC

--16) List top 5 locations (Zip Code) where the products sold most in last 27 years.

SELECT TOP 5 o.ShipPostalCode, SUM(od.Quantity)
FROM "Order Details" od left join Orders o on od.OrderID = o.OrderID
Where o.OrderDate > DATEADD(year, -27, GetDate())
GROUP by o.ShipPostalCode
Having o.ShipPostalCode is not NULL
Order By SUM(od.Quantity) DESC

--17) List all city names and number of customers in that city.     

SELECT c.City, Count(*) as Count
FROM Customers c
GROUP BY c.City
Order by Count DESC

--18) List city names which have more than 2 customers, and number of customers in that city

SELECT c.City, Count(*) as Count
FROM Customers c
GROUP BY c.City
Having Count(*) > 2
Order by Count DESC

--19) List the names of customers who placed orders after 1/1/98 with order date.

Select DISTINCT c.contactname
From Customers c left Join Orders o on c.CustomerID = o.CustomerID
Where o.OrderDate > '1998-01-01'

--20) List the names of all customers with most recent order dates

select c.ContactName, MAX(o.OrderDate) as 'most recent order dates'
From Customers c left Join Orders o on c.CustomerID = o.CustomerID
GROUP by c.CustomerID, c.ContactName

--21) Display the names of all customers  along with the  count of products they bought

select c.ContactName, IsNULL(SUM(od.Quantity),0)
From Customers c left Join Orders o on c.CustomerID = o.CustomerID left join "Order Details" od on o.OrderID = od.OrderID
group by c.CustomerID, c.ContactName

--22) Display the customer ids who bought more than 100 Products with count of products.

select c.CustomerID, IsNULL(SUM(od.Quantity),0)
From Customers c left Join Orders o on c.CustomerID = o.CustomerID left join "Order Details" od on o.OrderID = od.OrderID
group by c.CustomerID
having SUM(od.Quantity) > 100

--23) List all of the possible ways that suppliers can ship their products. Display the results as below

SELECT s.CompanyName AS "Supplier Company Name", sh.CompanyName AS "Shipping Company Name"
from Shippers s cross join suppliers sh

--24) Display the products order each day. Show Order date and Product Name.

SELECT o.OrderDate AS "Order Date", p.ProductName AS "Product Name"
FROM Orders o JOIN "Order Details" od ON o.OrderID = od.OrderID JOIN Products p ON od.ProductID = p.ProductID
ORDER BY o.OrderDate;

--25) Displays pairs of employees who have the same job title.

select e1.LastName +' '+e1.FirstName, e2.LastName +' '+e2.FirstName
from Employees e1 cross join Employees e2
where e1.title = e2.title and e1.EmployeeID != e2.EmployeeID

--26) Display all the Managers who have more than 2 employees reporting to them.

SELECT e2.LastName +' '+e2.FirstName
from Employees e2
where EmployeeID in
(
select e1.ReportsTo as ManagerID
from Employees e1
group by e1.ReportsTo
having count(e1.ReportsTo) > 2
)

--27) Display the customers and suppliers by city. The results should have the following columns

SELECT City, CompanyName, ContactName, 'Supplier' as 'Type'
From Suppliers s 
union 
Select City, CompanyName, ContactName, 'Customer' as 'Type'
from Customers c
ORDER by s.city

