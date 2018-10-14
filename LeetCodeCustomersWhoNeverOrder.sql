select c.name as Customers from customers c where c.Id not in (select o.CustomerId from Orders o)
