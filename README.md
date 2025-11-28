# MyTunes

An *Extremely Simple* implentation of .NET MAUI Community Toolkit Media Element Sample Application

Based on the [Microsoft .NET MAUI Community Toolkit Media Element Documentation](https://learn.microsoft.com/en-us/dotnet/communitytoolkit/maui/views/mediaelement) 

[For Complete Fully Featured Sample Applications check here](https://github.com/CommunityToolkit/Maui/tree/main/samples)

## Very Simply Features

- Play, Pause and Stop an emebeded mp4 video  
- implementation of the MVVM design pattern using Community Toolkit MVVM
- add binding of CurrentState to a View

## EVENTUALLY WILL ADD 

- better ui and layout 
- ability to add more videos
- add playlist functionality

## Breaking Changes with Current Versions of DOTNET 10

- DO NOT UPDATE TO DOTNET 10/ DOTNET MAUI 13, nor respective nuget packs
- breaking changes, see release notes 
- To build, run and debug, the following steps worked 

### 1: using VS Code on macOS 

- clone this repo 
- open folder - save workspace as 
- remove current DOTNET MAUI, C# and D# Dev Kit extensions

### 2: install vscode extensions

- dotnet install tool 2.3.7
- dotnet maui 1.10.18
- C# 2.39.22
- C# Dev Kit 1.70.3

### 3: nuget packages

- dotnet add package Microsoft.Extensions.Logging.Debug --version 9.0.110 

- dotnet add package Microsoft.Maui.Core --version 9.0.120 

- dotnet add package Microsoft.Maui.Controls --version 9.0.120 

- dotnet add package Microsoft.Maui.Essentials --version 9.0.120  

- dotnet add package CommunityToolkit.Maui --version 12.0.0 

- dotnet add package CommunityToolkit.Maui.MediaElement --version 6.1.3

- sudo xcode-select --switch /Applications/Xcode-26.0.app  

- sudo dotnet workload install maui  

- sudo dotnet workload install maui-android  

- [Download Microsoft Open JDK 21 from](https://learn.microsoft.com/en-us/java/openjdk/download)

- run and install microsoft-jdk-21.0.9-macos-x64.pkg

### 4: in VS Code 

- configure iOS & macOS - refresh enviroment 

- configure Android - Select Java SDK 21 path 

- configure Android - Refresh Android enviroment

- now can select the csproj file, run and debug

### 5: run and debug

- App should run, play, pause and stop 
- Android only allows using player controls 
- Can close app 
- Only build mshs should be 

### Hopefully the only debug output will be :

- Binding could be compiled to improve runtime performance if x:DataType is specified. See https://learn.microsoft.com/dotnet/maui/fundamentals/data-binding/compiled-bindings for more information.


-  This call site is reachable on: 'Android' 21.0 and later. 'AppBuilderExtensions.UseMauiCommunityToolkitMediaElement(MauiAppBuilder, Action<MediaElementOptions>?)' is only supported on: 'Android' 26.0 and later, 'iOS' 15.0 and later, 'maccatalyst' 15.0 and later, 'Tizen' 6.5 and later, 'Windows' 10.0.17763 and later. (https://learn.microsoft.com/dotnet/fundamentals/code-analysis/quality-rules/ca1416)

# Legal Notices

Microsoft and any contributors grant you a license to the Microsoft documentation and other content
in this repository under the [Creative Commons Attribution 4.0 International Public License](https://creativecommons.org/licenses/by/4.0/legalcode),
see the [LICENSE](LICENSE) file, and grant you a license to any code in the repository under the [MIT License](https://opensource.org/licenses/MIT), see the
[LICENSE-CODE](LICENSE-CODE) file.

Microsoft, Windows, Microsoft Azure and/or other Microsoft products and services referenced in the documentation
may be either trademarks or registered trademarks of Microsoft in the United States and/or other countries.
The licenses for this project do not grant you rights to use any Microsoft names, logos, or trademarks.
Microsoft's general trademark guidelines can be found at http://go.microsoft.com/fwlink/?LinkID=254653.

Privacy information can be found at https://privacy.microsoft.com/en-us/

Microsoft and any contributors reserve all other rights, whether under their respective copyrights, patents,
or trademarks, whether by implication, estoppel or otherwise.
