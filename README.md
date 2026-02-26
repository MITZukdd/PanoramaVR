# PanoramaVR

**PanoramaVR** is a unity package offers tools, scripts and prefabs to create immersive 360° VR experiences in Unity

## Features
* Spheres with Insideout shader that displays 360° panoramas for users
* navigation between views
* supports showing screen-space ui in VR
* navigation between screen space ui elements
* Button prefabs with text and images that appear upon hovering 
* Lots of prefabs for easy and global changing of elements

## System requirements

* Unity 2022.3 oder höher [Unity - Manual: System requirements for Unity 2022.3](https://docs.unity3d.com/2022.3/Documentation/Manual/system-requirements.html)
* Windows 10/11
* git lfs [git-lfs: Git extension for versioning large files](https://github.com/git-lfs/git-lfs?utm_source=gitlfs_site&utm_medium=repo_link&utm_campaign=gitlfs)

## Usage
 
### Option 1 - Open Repo as Unity Project
1. clone Repository : `git clone https://github.com/MITZukdd/PanoramaVR.git`
2. In the UnityHub add project from disc
3. Switch Platform in buildsettings to android
4. load `PanoramaVRSampleScene` scene from Assets/PanoramaVR/Samples
5. If you encounter an issue where all textures and image files are missing/generate an import error, the culprit is most likely git lfs. Try running `git lfs install` and then `git lfs fetch`

### Option 2 - Load Project as Unitypackage into an existing project
0. Switch Platform in buildsettings to android, if not already done
1. copy this into your manifest.json (located in the Packages directory) `"com.nobi.roundedcorners": "https://github.com/CelinaStransky/Unity-UI-Rounded-Corners.git",` and let Unity load the package
2. Go into the Unity Package manager
3. Click "Add package from git URL"
4. Enter ```https://github.com/MITZukdd/PanoramaVR.git?path=/Assets/PanoramaVR``` and wait until everything has imported
5. If a warning appears that the new Input system is not enabled in the player settings, click "YES" to enable the backends. This will restart the editor
6. Go to *Package Manager* &rarr; *XR Interaction Toolkit* &rarr; *Samples* and import the *Starter Assets* and the *XR Device Simulator*
7. If you want the package to be writable, go into the ``Tools`` Tab in the Unity Editor and click "Embed PanoramaVR Package". This will embed the package into your project and make the contents writable. <br> **Note** This severs the connection to the git repository
8. If you made the package writable you can load `PanoramaVRSampleScene` scene from Packages/PanoramaVR/Samples. Otherwise you can copy the scene into your Asset folder and load it

>**Note** This might generate Errors with Burst. This may be fixed by closing the project, deleting the Library folder and reopening the project 


## Project content

* `Documentation` contains more details about the sample scene and its content
* `Editor` (Helpful) Editor Shortcuts
* `Media` videos, images and panoramas for the sample scene
* `Scripts` script for navigation, video playing, ui navigation etc.
* `UI` Prefabs and examples for screen-space ui in VR

## More Info

This project is a result of the of the [VR Surgery Suite](https://github.com/MITZukdd/VR-OP-Saal) created by the MITZ at TU Dresden. To see the full scenario and get more info head over there.

## Issues 
If you encounter an isse with this project please report it via [GitHub Issues](https://github.com/MITZukdd/PanoramaVR/issues)


## Licence

The GitHub repository "PanoramaVR" is licensed under CC-BY-SA-4.0 (https://creativecommons.org/licenses/by-sa/4.0/). See the `LICENSE` file for details.

## Licensing of other tools

Additional tools were used for development in Unity. This project contains code from an external repository:

**Unity-UI-Rounded-Corners**
[Unity-UI-Rounded-Corners](https://github.com/CelinaStransky/Unity-UI-Rounded-Corners) Fork by Celina Stransky,
[Original project by Kirill Evdokimov](https://github.com/kirevdokimov/Unity-UI-Rounded-Corners) licensed under the MIT License