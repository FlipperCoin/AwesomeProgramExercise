# Autofac Exercise
This repository contains an exercise in application initialization based on autofac.

## Introduction
In this repo you can find a solution named "AwesomeProgram".  
The solution contains a program that is already fully implemented, but not initiated. Your job is to fix that!

## Solution Overview
The solution contains:  
1. Configuration  
    1. app_config.yml - the app's configuration, which is already configured properly  
    2. autofac_config.json - autofac components config, which is empty for now 
2. Projects  
    1. AwesomeProgram.Base - implementations
    2. AwesomeProgram.Common - models
    3. AwesomeProgram.Core - the program's main interfaces
    4. AwesomeProgram.Runner - the startup project, a dotnet core 2.2 console app with a main function that only loads the configuration file into a Configuration model

## The Exercise
### Phase 1
1. Add the Autofac NuGet package as a project dependency in the Runner project  
NOTE: you can find the package in the package source []
2. Create a ContainerBuilder and start adding the services needed for the Facade class
3. Build the container 
4. Resolve Facade and AsyncStartableRunner  
    1. Notice that AsyncStartableRunner requires an "IEnumerable\<IAsyncStartable>", and because you have registered the dispatcher and receiver they would be provided here.
5. init the Facade and run the program with the AsyncStartableRunner
### Phase 2
WIP