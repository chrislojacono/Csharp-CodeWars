/* Write a SQL query for a report that provides the following information for each person in the Person table, regardless if there is an address for each of those people:*/
Select P.FirstName, P.LastName, A.City, A.State
From Person P
        left Join Address A
        on (P.PersonId = A.PersonId)

/*Write a SQL query to get the second highest salary from the Employee table. */
SELECT MAX(Salary) as SecondHighestSalary 
FROM Employee WHERE Salary 
NOT IN (SELECT MAX(Salary) FROM Employee);