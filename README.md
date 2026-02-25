# PanoramaVR

**VPanoramaVR** is a unity package offers tools, scripts and prefabs to create immersive 360° VR experiences in Unity

## Features

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

### Option 2 - Load Project as UnityProject into an existing project
1. Go into the Unity Package manager
2. Click "Add package from git URL"
3. Enter ```https://github.com/MITZukdd/PanoramaVR?path=/Assets/PanoramaVR```
4. load `PanoramaVRSampleScene` scene from Packages/PanoramaVR/Samples


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