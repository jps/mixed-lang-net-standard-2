# Tutorial

## Create Solution 

```
	mkdir MixedLang | cd

	dotnet new sln --name MixedLang
```

## Create Web project 

```
	dotnet new reactredux --name Web --output Web

	dotnet sln add .\Web\MixedLang.csproj
```

## Create Data Access project

```
	dotnet new classlib --name DataAccess --output DataAccess -lang F# 

	dotnet sln add .\DataAccess\DataAccess.fsproj
```

## Reference Data Access from Web project 

```
	cd .\Web\

	dotnet add reference ..\DataAccess\DataAccess.fsproj
```

## Build sln

	not required for .net core v2.0+

```
	dotnet restore
```

```
	dotnet build MixedLang.sln
```

