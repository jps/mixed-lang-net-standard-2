# Tutorial

## Create Solution 

```
	mkdir MixedLang | cd

	dotnet new sln --name MixedLang
```

## Create web project 

```
	dotnet new reactredux --name Web --output Web

	dotnet sln add .\Web\MixedLang.csproj
```

## Create data access project

```
	dotnet new classlib --name DataAccess --output DataAccess -lang F# 

	dotnet sln add .\DataAccess\DataAccess.fsproj
```

## Reference Data Access from web proejct 

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

