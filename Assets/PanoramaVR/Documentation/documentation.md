# PanoramaVR

This template can be used to create immersive VR experiences in Unity, using 360° Panoramic images

## Features
* Spheres with Insideout shader that displays 360° panoramas for users
* navigation between views
* supports showing screen-space ui in VR
* navigation between screen space ui elements
* Button prefabs with text and images that appear upon hovering 
* Lots of prefabs for easy and global changing of elements


## Getting started

In Assets/PanoramaVR/Samples you can find the ``PanoramaVRSampleScene``. This scene contains all the functionality, that makes up the PanoramaVR package.

> This scene is a subset of the [VR Surgery Suite](https://github.com/MITZukdd/VR-OP-Saal). To see the full scenario head over there.

This scene includes


| GameObject                  | Purpose                                                                                       |
| :-------------------------- | :-------------------------------------------------------------------------------------------- |
| Viewpoint                   | Quick Navigation to the users viewpoint                                                       |
| ---XR---                    | Holds all functionality related to XR and Interaction handling                                |
| ---Views---                 | Holds all GameObjects that represent what the user sees                                       |
| ---UI Canvas---             | Container for the Screen-space canvas elements                                                |
| ---ButtonFeedbackManager--- | Adds Sound and Haptic Feedback to all Button Components at runtime                            |
| QuitWorkaround              | In some builds the home button could not close the application. This is a workaround for that |

To test the scenario in Playmode, without a headset set the `XR Origin (XR Rig)` active in the hierarchy, and press Play / Strg+P

#### Walktrough 
You start in the empty Start view with the Introduction panel. Click "Starten" to be teleported the next view. Interact with the red ActionHotspot until they are all green. Only then you can continue to the next view.
In the toilet room you also have to interact with all the red ActionHotspots. However this time, the InteractionChecker dictates the order in which Hotspots appear.
You can then enter the OR.

In the OR you can freely switch around the different positions, and explore Information Panels and videos.

## Helpful Shortcuts

This project defines some custom shortcuts in `Assets/PanoramaVR/Editor` that may help during development

| Key | Purpose                            |
|:----|:-----------------------------------|
| I   | Toggles the current Object in the Editor Active/Inactive  |
| U   | Logs the distance of a Gameobject to the Viewpoint to the Debug Console |
| G   |  Moves the current Object to be 2.1 units away from the Viewpoint                                   |

## Views

Views are Sphere objects that render a spherical 360° panoramic image on the inside of the Sphere.

> Views must have unique names, as the View Navigation depends on them

## Navigation

There are several scripts to navigate between the views and to show Screen Space interactable panels

### View Navigation

> `Assets/PanoramaVR/Scripts/navigation.cs`

* Assign this script to any GameObject with a Button component that you want to use to navigate to a new view

| Field  | Purpose                                            |
| ------ | -------------------------------------------------- |
| Target | String, Name of the View that should get activated |

### UI Navigation

> `Assets/PanoramaVR/Scripts/uiNavigation.cs`

* Assign this script to any GameObject with a Button component that you want to use to open a screen-space UI panel, from the ---Image UI Canvases--- Holder

| Field  | Purpose                                                |
| ------ | ------------------------------------------------------ |
| Target | String, Name of the UI Panel that should get activated |

This will work, for all GameObjects that are a child GameObject of the ---Image UI Canvas--- GameObject, so make sure they are located appropriately in the hierarchy.
Opening a new UI Canvas using the ``uiNavigation`` while another is active will deactivate the one currently visible, and open the new one instead

### Video Navigation

Additionally to the "normal" Ui Canvases there is the ```Video``` Ui Canvas, which upon activation with ``videoNavigation.cs``, will not close any currently open UI Canvases. Instead, the Video Canvas will be opened in front.

| Field  | Purpose                                                |
| ------ | ------------------------------------------------------ |
| Target | Video File, tells the Video Canvas which video to play |

**Note** Videos that should be played using this method must first be added to the ``VideoManager`` Component in the ``Videos`` list field

## Creating a new View

1. Navigate into `Assets/PanoramaVR/Media/panorama/Materials`
2. Copy the `ShaderMaterialTemplate.mat` and rename the copy to whatever you like
3. If not done already, import your panoramic image into `Assets/PanoramaVR/Media/panorama` <br> **Note** Make sure to increase `Max Size` in the images import settings. By Default Unity limits imported images to 2048px, which makes the views look blurry. However this bloats build sizes, so make sure to choose an appropriate setting
4. Drag you panoramic image in the texture slot of the new material, or click in the empty Texture slot and choose from the available list
5. Copy one of the available ExampleView's and assign your newly created Material to the Material Slot of the `MeshRenderer` component of the view

### Navigating to the New View

* Create a GameObject with a button component
* Add the navigation Component to the Gameobject
* Write the name of your new View in the Target field
* Place the Object in a view that is already reachable

## Creating new Screen Space UI Panels

The easiest way is to copy an existing prefab from Assets/PanoramaVR/UI/UI Panels and work from that.
To make the new UI Canvas accessible via the uiNavigation component :
* create an empty GameObject as a child of `---Image UI Canvas---`
* give the GameObject a meaningful name. This is the name used for adressing with the UIManager
* drag your newly created UI element as a child of the empty GameObject in the hierarchy
* On the Canvas component set :
    * Render mode to "Screen Space - Camera"
    * Assign the Main Camera to the Render Camera Slot
    * Set Plane Distance to one 
* On the Canvas Scaler component set:
    * UI Scale mode to "Scale with Screen size"
    * Reference Resolution to 2000x2000
    * Screen Match Mode to "Match Width or Height"
    * Match to 0.5

* Finished. Now your UI element appears in screen space for the user

## Manager GameObjects

| Field        | Purpose                                            |
|:-------------|:---------------------------------------------------|
| ViewManager  | Collects all References to Views, so that they are addressable by the Navigation component during runtime |
| UIManager    | Collects all References to UI Panels, so that they are addressable by the uiNavigation component during runtime<br> The `Start` field can be either none, then no Panel is shown directly after startup, or one of the UI Panels, that will then be displayed directly after startup |
| VideoManager | Collects references to videos that are used with the Video UI Panel. All videos that you want to use with the Video UI panel muss be added to this list|


## Interaction scripts

* `changeUponClick.cs` Add this component to buttons that should change their appearance and text upon beeing clicked. The fields `Icon`,`New Description` and `Old Description` do not need to be assigned, as long as the corresponding children follow the naming convention Icon&rarr;Icon, Title&rarr; Old Description and Description&rarr;New Description
* `InteractionChecker.cs` Add this component to navigation Hotspot buttons, to ensure some specific hotspots were interacted with before users can continue to the next view. The list `Buttons In Scene` is checked and also specifies the order in which buttons appear, when ``Ordering=true`` <br> **Note** this works by checking wheter buttons are still interactable. Therefore these buttons must have the `changeUponClick` component, which changes buttons and makes them non interactable.
