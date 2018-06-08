# NET.Core demo audio app

## Overview

This demo code demonstrates how to enable .NET Core to play audio with the help of NodeServices and Node.js.

Due to its platform-independent nature, .NET Core doesn't have any native capabilities to play audio on the device that it is running on. However, Node.js has various packages that can achieve it.

[NodeServices](https://github.com/aspnet/JavaScriptServices) (a.k.a. JavaScriptServices) is a .NET Core library that enables seemless integration between Node.js and .NET Core code.

## Prerequisites

1. Any IDE that is suitable for compiling .NET Core code (e.g. Visual Studio 2015, Visual Studio 2017, Visual Studio Code, etc.)
2. Node.js

## Usage

The demo project uses [play-sound](https://www.npmjs.com/package/play-sound) NPM package. However, there is a number of other NPM packages that can achieve the same goal.

In order to run the app, perform the following steps:

1. Run "npm install" command inside "NetCoreAudioDemo" folder. This will create "node_modules" folder
2. Build the solution
3. Navigate to the folder containing output binaries
4. Run the following command:

```bash
dotnet NetCoreAudioDemo.dll {space-separated fully qualified paths to audio files}
```

The command will attempt to play all audio files specified as command arguments.

If the compiled binaries need to be transferred to a different environment, ensure that "npm install" command is executed before the application is ran.

Please note that play-sound library cannot play sound on its own. It relies on one of the player apps, listed on its NPM page. The solution includes a compiled version of [cmdmp3](https://github.com/jimlawless/cmdmp3), the player specific to Windows.
