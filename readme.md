# Coded UI - Specflow example test project

Requires Visual Studio Enterprise for test libraries

Install nuget packages and build project to run windows calculator tests

***How to run tests from Visual Studio
1. Open the project
2. Open Test Explorer from Test/Windows if necessary
3. Build the solution to generate test dlls and populate the Test Explorer
4. Right click to run or debug tests of your choosing or 'Run All'

***How to run tests from command line
1. Open command prompt in the base directory containing Run.bat file
2. From command prompt run 'Run.bat <FEATURE_SCENARIO_TAG(Optional)>'

***How to set up project to manipulate feature files
1. Open the solution in Visual Studio and build it
2. Navigate to Tools/Extensions and Updates...
3. Install Specflow for Visual Studio 2015
4. Go to Tools/Options and update Specflow Generation Mode to 'App Domain'
5. Right click a feature file and choose 'Run Custom Tool'
6. Open the generated code for the feature and verify it generated with Specflow 2.1
7. If there are errors, verify there are no additional versions of Specflow in 'C:\Users\<USERNAME>\.nuget\packages' and/or try to close and re-open visual studio