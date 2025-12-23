# MyTunes

An *Extremely Simple* implentation of .NET MAUI Community Toolkit Media Element Sample Application

THIS CODE IS PART OF LEARNING ENVIRONMENT. NO GAURANTEE OF ANY KIND IS MADE OR IMPLIED.

The following code is modified from the original sample available the [Microsoft .NET MAUI Community Toolkit Media Element Documentation](https://learn.microsoft.com/en-us/dotnet/communitytoolkit/maui/views/mediaelement) 

[For Complete Fully Featured Sample Applications check here](https://github.com/CommunityToolkit/Maui/tree/main/samples)


## NEW ##

- Code Changes for DotNet 10 

## Very Simple Features

- Play, Pause and Stop an emebeded mp4 video  

## Setting up 

- download and install dotnet 10 sdk 

- download and install open jdk 21.0.9

- clone this repo 

- open VS Code, open project 
    - should be prompted to install latest dotnet10 maui 
    - for Android, 
        - will need to set path for jdk, 
        - verify corret android sdk, build tools and vm are set and ready 
    - should be able to build, run and debug

## changes from latest release for dotnet9

- MyTunes.csproj
    - line 4, 5 - target frameworks
        - replace net9.0 with net10.0
    - lines 60-65 - item group
		- using "dotnet add package", upgrade to current versions of nuget packs 
		  - Microsoft.Extensions.Logging.Debug" Version="10.0.1"
	      - Microsoft.Maui.Core" Version="10.0.11" 
	 	  - Microsoft.Maui.Controls" Version="10.0.11"
		  - Microsoft.Maui.Essentials" Version="10.0.11"
          - CommunityToolkit.Maui" Version="13.0.0"
		  - CommunityToolkit.Maui.MediaElement" Version="7.0"

## Release for DOTNET 9 
- this branch currently includes 
    - how to, list of deps, exts and packs to build MyTunes for Dotnet 9 
    - how to install Dotnet 10 sdk and keep Dotnet 9 also 
    - for simplicity will be separating into separate documentation 

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
