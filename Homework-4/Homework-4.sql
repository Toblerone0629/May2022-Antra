--1. What is index; types of indices; pros and cons
-- An index is an indicator or measure of something
-- pros: easy to sort and group datas
-- cons: creates extra row that would reduce the speed of doing search in table

--2. What's the difference between Primary key and Unique constraint?
-- We can use Primary key for multiple Unique constraints
-- Unique allow one NULL value, Primary key do not allow NULL values

--3. Tell me about check constraint
-- A check constraint is a type of integrity constraint in SQL 
--		which specifies a requirement that must be met by each row in a database table

--4. Difference between temp table and table variable
-- temp table result can be used by multiple users, table variable can be used by only current user
-- temp table will store in tempdb, table variable will store in physical memory primarily

--5. Difference between WHERE and HAVING
-- WHERE is used to filter the records from the table based on the specified condition. 
-- HAVING is used to filter record from the groups based on the specified condition.

--6. Difference between RANK() and DenseRank() ¡ª value gap
-- Rank will skip next available ranking value such as Rank() as 1 1 3 4 5 and DenseRank() would be 1 1 2 3 4

--7. COUNT(*) vs. COUNT(colName)
-- COUNT(*) will count all rows in table and include NULL values
-- COUNT(colName) will count all rows in specific column and exclude NULL values

--8. What's the difference between left join and inner join? JOIN and Subquery, which one has a better performance, why?
-- Left Join will return all records from left table, inner join will return records on both sides
-- Join have better performance than Subquery, because the server optimize the join performance

--9. What is correlated subquery
-- Correlated subquery is a way to read data from one table and compare value to others

--10. What is a CTE, why do we need CTE?
-- CTE is Common Table Expression. It is a temporary named result set that could reference within SELECT, INSERT, UPDATE, DELETE statements
-- because sometimes we need to build recursive query for sorting and reference to table itself for multiple times

--11. What does SQL Profiler do?
-- SQL Server Profiler is a graphical user interface to SQL Trace for monitoring an instance of the Database Engine or Analysis Services

--12. What is SQL injection, how to avoid SQL injection?
-- SQL injection is a web security vulnerability that allows an attacker to interfere with the queries that an application makes to its database
-- 1) Stop writing dynamic queries with string concatenation
-- 2) prevent user supplied input which contains malicious SQL from affecting the logic of the executed query

--13. Difference between SP and user defined function? When to use SP when to use function?
-- SPs can change database objects. 
-- Inline User-Defined Functions can be treated like views with parameters and can be used in row set operations and JOINs
-- SP can return zero, single or multiple values, Function must return single value

--14. Criteria of Union and Union all? Difference between UNION and UNION ALL
-- UNION will execute and return something under the situation: There must be the same number of columns retrieved in each SELECT statement to be combined
-- UNION will delete duplicates while UNION ALL will keep duplicates

--15. Steps you take to improve SQL Queries
-- 

--16. concurrency problem in transaction
-- Concurrency problems occur when multiple transactions execute concurrently in an uncontrolled manner

--17. what is deadlock, how to prevent
-- deadlock occurs when two (or more) processes lock the separate resource
-- Deadlock can be prevented by eliminating any of the four necessary conditions, 
--        which are mutual exclusion, hold and wait, no preemption, and circular wait

--18. what is normalization, 1NF - BCNF, benefits using normalization
-- Normalization is the process to eliminate data redundancy and enhance data integrity in the table. 
--		Normalization also helps to organize the data in the database. 
--		It is a multi-step process that sets the data into tabular form and removes the duplicated data from the relational tables.
-- Reduces redundant data, provides data consistency within database, more flexible database design, higher database security

--19. what are the system defined databases?
-- System databases are defined by Microsoft and are needed for SQL Server to operate, such as Master, Model, MSDB, TempDB, Resource

--20. composite key
-- composite key is combination of two or more columns in a table that can be used to uniquely identify each row in the table

--21. candidate key
-- candidate key is a specific type of field in a relational database that can identify each unique record independently of any other data

--22. DDL vs. DML
-- DDL is used to specify the database schema database structure.
-- DML is used to access, modify or retrieve data from the database

--23. ACID property
-- provide a mechanism to ensure the correctness and consistency of a database in a way such that each transaction is a group of operations that acts as a single unit, 
--		produces consistent results, acts in isolation from other operations, and updates that it makes are durably stored

--24. table scan vs. index scan
-- table scan will iterate over all table rows
-- index scan will iterate over all index items
-- index scan is faster than table scan because of the index

--25. Difference between Union and JOIN
-- JOIN combine data into new columns
-- UNION combine data into new rows