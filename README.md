# MyTunes

An *Extremely Simple* implentation of .NET MAUI Community Toolkit Media Element Sample Application

Based on the [Microsoft .NET MAUI Community Toolkit Media Element Documentation](https://learn.microsoft.com/en-us/dotnet/communitytoolkit/maui/views/mediaelement) 

[For Complete Fully Featured Sample Applications check here](https://github.com/CommunityToolkit/Maui/tree/main/samples)

## BREAKING CHANGES WITH DOTNET 10 
- will update code once, Microsoft releases tutorial docs for DOTNET 10 & COMMUNITY TOOLKIT

## NEW ##
- Code Changes for Windows 11 platform 
    - not tested in previous Windows versions
    - have not tested these changes using DOTNET 10
    - not tested in VS CODE on a MAC

## Very Simple Features

- Play, Pause and Stop an emebeded mp4 video  

## EVENTUALLY WILL ADD 

- better ui and layout 
- ability to add more videos
- add playlist functionality

## using VS Code, continue with or Reinstall Dotnet 9 and Previous Versions of exts and packs 

- Verify that TargetFrameworks and Package References 
    - These must specify versions of each dependency

- Once build and debug are successful, 
    - Keep previous versions of sdks, exts and packs
    - then can install dotnet 10 sdks, associated exts and packs
        - the newer versions, not being referenced, should not affect the build and debuging

- *Kavaet: have not been able to do this successfully in any version Visual Studio 2022 or 2026*
    - *these editions only support the current versions of sdks, and nuget packs, (i.e. DOTNET 10)*

### Code Changes for Windows 11 platform *(not tested in previous Windows versions)*

- the following were not needed on macOS for sucessful run and debug in Android, iOS and macCatalyst platforms 
    - may have to test for Windows platform, so these only are used for Windows

- MyTunes.csproj
    - line 5
        - verify the correct Windows platform is specified
        - for my Windows 11 test machine the Target Framework need to be *net9.0-windows10.0.19041.0*
    - lines 37 & 38
        - SupportedOSPlatformVersion & TargetPlatformMinVersion can be lower such as *10.0.17763.0* 

    - line 36
        - suported version for Android can be set to 26, 
            - but this is not a make or break, just gets rid of anyouying debug error 
        - However, in Android Studio, 
            - make sure to install Android SDK 15, API Level 35, Build Tools version 35.0.0
                - then configure a Virtual Device that runs these 

- App.xaml line 4
    - add assembly reference to namespace 
        - xmlns:sf="clr-namespace:CommunityToolkit.Maui.Core.Views;assembly=CommunityToolkit.Maui.Core"

- MauiProgram.cs lines 20-23 
    - add handler to register CommunityToolkit.Mauui.View.MediaElement is 

- make sure to save your changes =)

- should not have other build or runtime errors, with this code =)

### 1 : using VS Code (**not** Visual Studio 2022 or 2026) the following steps 

- clone this repo 
- VS Code, open folder - save workspace as - just in case 
    - so VS Code will show the project under the Solution Explorer  
- remove *ALL* DOTNET MAUI, C# and D# Dev Kit extensions and packs
    - just in case 
- close workspace
- close VS Code

- if not already 
    - UNINSTALL *ALL* DOTNET SDK using the SDK Installer you used 
        - I eneded up having to launch VS 2022 and VS 2026 and *uninstall* all MAUI SDK AND COMPONENTS
            - good grief =)

- INSTALL ONLY THE LAST VERSION OF DOTNET 9.0.308
    - This project is specific to Media Element
        - if using other Communnity Toolkit or Maui subsets, you can check the deps needed 
            - check the Maui Marketplace, Github Repo or Nuget info page 
                -  for each ext and pack, should show the deps needed, features and rel notes 

### 2: previous version of VS Code extensions

- restart VS Code 
- open MyTunes Workspace
- in the extentsion sidebar
    - right click on the extension, choose to install specific versions 
- dotnet install tool 2.3.7
- dotnet maui 1.10.18
- C# 2.39.22
- C# Dev Kit 1.70.3
- restart exts 


### 3: nuget packages

- in VS Code, with MyTunes workspace open, in a terminal 

    - dotnet add package Microsoft.Extensions.Logging.Debug --version 9.0.110 

    - dotnet add package Microsoft.Maui.Core --version 9.0.120 

    - dotnet add package Microsoft.Maui.Controls --version 9.0.120 

    - dotnet add package Microsoft.Maui.Essentials --version 9.0.120  

    - dotnet add package CommunityToolkit.Maui --version 12.0.0 

    - dotnet add package CommunityToolkit.Maui.MediaElement --version 6.1.3

    - if using a Mac
        - sudo xcode-select --switch /Applications/Xcode-26.0.app  

    - sudo dotnet workload install maui  

    - sudo dotnet workload install maui-android  

        - supported version for Android can be set to 26
        - in Android Studio, make sure to install Android SDK 15, API Level 35, Build Tools version 35.0.0
                - then configure a Virtual Device that runs these 

    - LAST BUT CRUCIAL FOR WINDOWS PLATFORM
        - sudo dotnet workload install maui-windows 

### JDK for Andriod 

- [Download Microsoft Open JDK 21 from](https://learn.microsoft.com/en-us/java/openjdk/download)

- run and install microsoft-jdk-21.0.9-macos-x64.pkg

### 4: in VS Code command pallete

- close and open VS CODE and My Tunes Workspace

- using the Command Pallete

    - configure iOS & macOS - refresh enviroment 

    - configure Android - Select Java SDK 21 path 

    - configure Android - Refresh Android enviroment

- now can select the csproj file, run and debug


### 5: run and debug

- App should run, play, pause and stop 
- Android only allows using player controls 

### There will be quite a few of these Debug warnings :

- Binding could be compiled to improve runtime performance if x:DataType is specified. See https://learn.microsoft.com/dotnet/maui/fundamentals/data-binding/compiled-bindings for more information.

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
