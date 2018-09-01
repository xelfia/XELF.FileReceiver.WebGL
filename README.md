# XELF.FileReceiver.WebGL
Template for a `Unity WebGL Player` using `HTML File drag-and-drop` interfaces

## Targeted Scenario
* Using `Unity WebGL Player` (Web)
* Want to **Load a local file selected by the user**.
* Simple UI: File `Drag and drop` into the frame.

## Target Environments
* Platform: `Unity WebGL Player`
* Dependent APIs: HTML drag-and-drop interfaces (HTML5 File APIs)

## Tested with
* Unity 2018.2.6f1
* Windows 10 (64 bit)
* Google Chrome 68.0.3440.106 (64 bit)

## Example
* View ☛ [Example WebGL](https://xelfia.github.io/XELF.FileReceiver.WebGL)
  * You can drop your local file into the WebGL frame.
  * `SIZE:` will show the size [bytes] of the file.

## How to Customize
1. Open `FileReceiver`/`Example`/`Scenes`/`SampleScene.unity`
2. Modify it or clone it.
3. Create your script file by copying [`FileReceiver.cs`](Assets/FileReceiver/Scripts/FileReceiver.cs) or [`FileReceiverStats.cs`](Assets/FileReceiver/Example/Scripts/FileReceiverStats.cs).
4. Here, assumes that you set the file name `MyFileReceiver.cs` and the class name `MyFileReceiver`. 
5. Add your C# code into `LoadFile` method. (Your turn)
6. Select the GameObject named `FileReceiver` (or create it when a new scene)
7. Add the component `MyFileReceiver` (and remove the components `FileReceiver`/`FileReceiveStats` if it exists)
8. Open the `Main Menu`:`File`/`Build Settings…`.
9. Switch `Platform` to `WebGL` (if not set)
10. Open `Player Settings…` and switch `PlayerSettings`/`Settings for WebGL`/`WebGL Template`➡`FileReceiver` (if not set)
10. Push `Build And Run` on `Build Settings`. (and wait building…)
11. Built WebGL page will open by your web browser.


