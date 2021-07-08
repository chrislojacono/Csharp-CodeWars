/* Write a SQL query for a report that provides the following information for each person in the Person table, regardless if there is an address for each of those people:*/
Select P.FirstName, P.LastName, A.City, A.State
From Person P
        left Join Address A
        on (P.PersonId = A.PersonId)

/*Write a SQL query to get the second highest salary from the Employee table. */
SELECT MAX(Salary) as SecondHighestSalary 
FROM Employee WHERE Salary 
NOT IN (SELECT MAX(Salary) FROM Employee);

/* Find all emails that exist in a column more than once*/
Select Email
From Person
Group by Email
Having Count(Email) > 1

/* Given the Employee table, write a SQL query that finds out employees who earn more than their managers. For the above table, Joe is the only employee who earns more than his manager.*/
Select E.Name as Employee 
From Employee E
 Join Employee  M
 on M.id = E.ManagerId
Where M.Salary < E.Salary

/* Suppose that a website contains two tables, the Customers table and the Orders table. Write a SQL query to find all customers who never order anything.*/
Select C.Name as Customers
From Customers C
Where Not Exists(Select * from Orders O
                Where C.Id = O.CustomerId)