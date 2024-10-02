USE AdventureWorks2019

--1)

select 
p.ProductID, p.Name, p.Color, p.ListPrice
from Production.Product p

--2)

select 
p.ProductID, p.Name, p.Color, p.ListPrice
from Production.Product p
where p.ListPrice != 0

--3)

select 
p.ProductID, p.Name, p.Color, p.ListPrice
from Production.Product p
where p.Color is null

--4)

select 
p.ProductID, p.Name, p.Color, p.ListPrice
from Production.Product p
where p.Color is not null

--5)

select 
p.ProductID, p.Name, p.Color, p.ListPrice
from Production.Product p
where p.Color is not null and p.ListPrice > 0

--6)

select p.Name +' '+ p.Color as 'Name + Color'
from Production.Product p
where p.color is not null

--7)

select p.Name as 'NAME', p.Color as 'COLOR'
from Production.Product p
where p.Name in ('LL Crankarm', 'ML Crankarm', 'HL Crankarm', 'Chainring Bolts', 'Chainring Nut', 'Chainring')

--8)

select p.ProductID, p.Name
from Production.Product p
where p.ProductID between 400 and 500

--9)

select p.ProductID, p.Name, p.Color
from Production.Product p
where p.Color =  'Black' or p.Color = 'Blue'

--10)

select p.name
from Production.Product p
where p.name like 'S%'

--11)

select p.Name, p.ListPrice
from Production.Product p
where p.name like 'S%'
order by p.Name asc

--12)

select p.Name, p.ListPrice
from Production.Product p
where p.name like 'S%' or p.name like 'A%'
order by p.Name asc

--13)

Select *
From Production.Product p
Where p.Name Like 'SPO[^K]%'
Order By p.Name

--14)

SELECT DISTINCT p.Color
FROM Production.Product p
ORDER BY p.Color DESC
