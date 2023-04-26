# Sample project with c# msbuild custom tasks

Requires dotnet core 6.0 installed.

## Using custom task without dependencies to any projects works

* In a shell go to: CustomTask

```
dotnet clean
dotnet build
dotnet pack
```

This packs the task and puts it in the  `./artifacts directory` (will be created in the root of this directory). Will be used by the next project as local NuGet feed.

 * Next in the shell go to: ConsoleAppUsingTask

```
dotnet clean
dotnet build
```
This project during the build will use the task. It succeeds and prints something out from that task.


## Using Custom task which has a dependency to a project fails

* In a shell go to: CustomTaskWithDependency

```
dotnet clean
dotnet build
dotnet pack
```
This packs the task and it's dependency project and puts it in the `./artifacts-dependency` directory (will be created in the root of this directory). Will be used by the next project as local NuGet feed.

 * Next in the shell go to: ConsoleAppUsingTaskWithDependency

```
dotnet clean
dotnet build
```
This project during the build will attemp to run the task. It however fails when running the task, as it fails to find the dependency's assembly the task is using.

```
....ConsoleAppUsingTaskWithDependency/AnotherSimpleApp/AnotherSimpleApp.csproj(15,5): error MSB4018: System.IO.FileNotFoundException: Could not load file or assembly 'SomeProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. The system cannot find the file specified.

```