Reference: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/
# Get Started with LINQ in C#
## LINQ and Generic Types (C#)
(https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/linq-and-generic-types)

LINQ query variables are typed as IEnumerable<T> or a derived type such as IQueryable<T>. When you see a query variable that is typed as IEnumerable<Customer>, it just means that the query, when it is executed, will produce a sequence of zero or more Customer objects.

If you prefer, you can avoid generic syntax by using the var keyword. The var keyword instructs the compiler to infer the type of a query variable by looking at the data source specified in the from clause. When you use IEnumerable<T> or var to declare LINQ query variables, compiled code are the same.
## Basic LINQ Query Operations (C#)
(https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/basic-linq-query-operations)
