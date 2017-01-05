Skybrud.Social.Pinterest
========================

### Installation

To install the Skybrud.Social.Pinterest, simply pick one of the three methods below:

1. [**NuGet Package**][NuGetPackage]  
   Install this NuGet package in your Visual Studio project. Makes updating easy.
2. [**ZIP file**][GitHubRelease]  
   Grab a ZIP file of the latest release; unzip and move the DLL files to the bin directory of your project.
3. [**Builds**][DropboxFolder]  
   I may occasional upload a build to Dropbox. These are builds in between releases, and are not tested at the same level as releases. As above, move `Skybrud.Social.Core.dll` to the bin directory of your project.





## Usage

##### Initializing a new OAuth client

The `PinterestOAuthClient` class is responsible for the raw communication with the Pinterest API as well as authentication. The class can be initialized with one of the constructors, or simply by setting the properties like in the examples below:

```C#
// Initialize and configure the OAuth client
PinterestOAuthClient client = new PinterestOAuthClient {
    AccessToken = "Insert your access token here"
};
```

or:

```C#
// Initialize and configure the OAuth client
PinterestOAuthClient client = new PinterestAuthClient {
    ClientId = "Insert your client ID here",
    ClientSecret = "Insert your client secret here",
    RedirectUri = "http://social.abjerner/pinterest/oauth/"
};
```

Authentication requires that you specify the client ID, client secret and redirect URI of your app (client).

* [**List of existing app** *at developers.pinterest.com*](https://developers.pinterest.com/apps/)


## Documentation

Although still a bit limited, further documentation can be found at the [Skybrud.Social website](http://social.skybrud.dk/pinterest/).





[NuGetPackage]: https://www.nuget.org/packages/Skybrud.Social.Pinterest
[GitHubRelease]: https://github.com/abjerner/Skybrud.Social.Pinterest/releases/latest
[DropboxFolder]: https://www.dropbox.com/sh/ubak1qionvji8mf/AACq5X5b2Ic6MPPZznrzfsl2a?dl=0
[Changelog]: https://github.com/abjerner/Skybrud.Social.Pinterest/blob/master/CHANGELOG.md
[Issues]: https://github.com/abjerner/Skybrud.Social.Pinterest/issues
