# DependencyHell

[Blog post](http://damian.laczak.net.pl/blog/2019/01/30/dependency-hell/)

The project here demonstrates how weird is .NET Framework looking for references of system packages. 

Summary:

- We want to use 4.1.1.3 version of System.Net.Http by using Nuget package.
- Visual Studio 'thinks' that we are using 4.2.0
- As the end result we end up with 4.0.0.0 (depends on the computer)