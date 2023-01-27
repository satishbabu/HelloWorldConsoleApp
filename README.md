"# HelloWorldConsoleApp" 

Write a super simple .NET Framework application to try out the command msbuild utility to download the nuget libraries

Following will download the required Humanizer libraries
'''
msbuild  -t:restore -p:RestorePackagesConfig=true
'''
