Reference: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/
# Get Started with LINQ in C#
## LINQ and Generic Types (C#)
(https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/linq-and-generic-types)

LINQ query variables are typed as `IEnumerable<T>` or a derived type such as `IQueryable<T>`. When you see a query variable that is typed as IEnumerable<Customer>, it just means that the query, when it is executed, will produce a sequence of zero or more Customer objects.

If you prefer, you can avoid generic syntax by using the var keyword. The var keyword instructs the compiler to infer the type of a query variable by looking at the data source specified in the from clause. When you use IEnumerable<T> or var to declare LINQ query variables, compiled code are the same.
## Basic LINQ Query Operations (C#)
(https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/basic-linq-query-operations)
 The `from` clause comes first in order to introduce the data source (`customers`) and the *range variable* (`cust`).
 
The range variable is like the iteration variable in a `foreach` loop except that no actual iteration occurs in a query expression. When the query is executed, the range variable will serve as a reference to each successive element in `customers`. 

The `group` clause enables you to group your results based on a key that you specify. 

custQuery is an IEnumerable<IGrouping<string, Customer>>. When you iterate over a query that produces a sequence of groups, you must use a nested `foreach` loop. The outer loop iterates over each group, and the inner loop iterates over each group's members.
## Data Transformations with LINQ (C#)
(https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/data-transformations-with-linq)
code refer to ex2/DataTransSample/DataTransSample

To create elements that contain more than one property from the source element, you can use an object initializer with either a named object or an anonymous type.

LINQ queries make it easy to transform data between in-memory data structures, SQL databases, ADO.NET Datasets and XML streams or documents. 
## Type Relationships in LINQ Query Operations (C#)
(https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/type-relationships-in-linq-query-operations)

