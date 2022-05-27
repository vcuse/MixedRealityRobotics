# Mista :sparkler:

Experiment Goal: Evaluate the use of Mixed Reality as an alternative to control robots with precision
- Developed for the GoFa™ CRB 15000.

## :card_index_dividers:	Files
- `Assets` 
    - Generated From the [Mixed Reality Toolkit (MRTK)](https://docs.microsoft.com/en-us/windows/mixed-reality/mrtk-unity/?view=mrtkunity-2021-05):
        - `Icons` : Destination of all 2D icons associated with the interfaces included in the Mixed Reality Toolkit.
        - `MixedRealityToolKit.Generated` : Destination of the Mixed Reality Toolkit's project settings.
        - `MRTK` : Destination of all shaders associated with the interfaces included in the Mixed Reality Toolkit.
    - `Materials` : Contains the materials used to define the appearence of objects used in scenes. ([On Materials](https://docs.unity3d.com/Manual/Materials.html))
    - `Objects and Prefabs` : Contains all Unity GameObjects and interfaces created for use in the project. ([On GameObjects](https://docs.unity3d.com/Manual/GameObjects.html); [On Prefabs](https://docs.unity3d.com/Manual/Prefabs.html))
    - `Packages` : Destination of the packages being used to implement communication between the Hololens application and the GoFa™ controller.
    - `RobotStudio` : Controllers for the GoFa™ CRB 15000.
    - `Scenes` : Contains all available scenes created within the project. ([On Scenes](https://docs.unity3d.com/Manual/CreatingScenes.html))
    - `Scripts` : Destination of all C# scripts that describe and define the behavior of the project interfaces and how the application communicates positional data to the ABB GoFa™.
    - `TextMeshPro` : Contains all resources associated with the TextMeshPro plugin.
    - `Textures` : Contains the finer mesh geometry for the materials of Unity GameObjects. ([On Textures](https://docs.unity3d.com/Manual/Textures.html))
    - `XR` : Destination of the OpenXR plugin's loaders and configuration settings.
    - `NuGet` : Package management system for 3rd-party Unity packages. (Manages the packages being used to implement communication between the Hololens application and the GoFa™ controller.)
- `Packages` : Storage destination of installed Unity packages including the Mixed Reality Toolkit, OpenXR, and other MR/AR plugins.
- `ProjectSettings` : Destination of the Unity project's settings.
- `UserSettings` : Destination of the current Unity project's user's settings.

## :nut_and_bolt: Dealing with the code

### Project Structure

- Each jogging interface separated out into individual scenes in the `Scenes/Interfaces` folder.
    - `BoundingBox` : An interface that uses the [bounds control](https://docs.microsoft.com/en-us/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/bounds-control?view=mrtkunity-2021-05) and [object manipulator](https://docs.microsoft.com/en-us/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/object-manipulator?view=mrtkunity-2021-05) to create a bounding box for virtual, hands-on manipulation of the ABB GoFa™ robotic gripper's positioning.
    - `Buttons` : An interface created using the [buttons](https://docs.microsoft.com/en-us/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/button?view=mrtkunity-2021-05) included with the Mixed Reality Toolkit.
    - `JoyStick` : An in-house interface created to mimick the joystick controls typically used by an ABB GoFa™ operator.
    - `ObjectManipulator` : An interface created using the [Object Manipulator](https://docs.microsoft.com/en-us/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/object-manipulator?view=mrtkunity-2021-05) included with the Mixed Reality Toolkit.
    - `Sliders` : An interface created using the [Slider UI](https://docs.microsoft.com/en-us/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/sliders?view=mrtkunity-2021-05) included with the Mixed Reality Toolkit.
    - `Trial` : A virtual display of the poster created for the 2022 VCU Research Symposium.
- Scenes in the `Scenes/Jogging` folder have several supplimentary uses.
    - To facilitate communication between the application, ABB RobotStudio®, and GoFa™
        - `GofaConversation` : A previous version of the `TalkToGofa` scene.
        - `TalkToGofa` : A helper scene that manages the communication between the Hololens application and the GoFa™ controller.
    - Implementation of helper GUIs for easier jogging interface development
        - `StartUp` : An interface, meant to launch at the start of the application, that is used to automatically connect to the ABB GoFa™ controller. 
        - `Vectors` : An interface that navigates the user to the available jogging interfaces.

### Technologies
- [Microsoft Hololens 2](https://www.microsoft.com/en-us/hololens/hardware?SilentAuth=1)
- [ABB GoFa™ CRB 15000](https://new.abb.com/products/robotics/collaborative-robots/crb-15000)
- [ABB RobotStudio®](https://new.abb.com/products/robotics/robotstudio)
- [abb_libegm](https://github.com/ros-industrial/abb_libegm) by the [ROS Industrial Project](https://rosindustrial.org/)
- [Windows Networking WNet Functions](https://docs.microsoft.com/en-us/windows/win32/wnet/about-windows-networking)
- [Unity version 2021.1.28f1 (or higher)](https://unity.com/products/unity-platform)
  - [Microsoft Mixed Reality Toolkit](https://docs.microsoft.com/en-us/windows/mixed-reality/mrtk-unity/?view=mrtkunity-2021-05)
  - [OpenXR Mixed Reality Plugin](https://docs.unity3d.com/Packages/com.unity.xr.openxr@1.4/manual/index.html)

## :computer: Building your local workspace

### Setting Up Your Unity Project

1. [Download the Unity Hub from Unity.com](https://unity.com/products/unity-platform)
    1. Your Unity version should be 2021.1.28f1 or higher
    2. [Choosing your Unity Version and installing the OpenXR plugin](https://docs.microsoft.com/en-us/windows/mixed-reality/develop/unity/choosing-unity-version)
2. [Setting Up Your Unity Version to Develop MR Project for Microsoft Hololens](https://docs.microsoft.com/en-us/windows/mixed-reality/develop/unity/unity-development-overview?tabs=arr%2CD365%2Chl2)
    1. [Install the Development Tools for Mixed Reality on Hololens 2](https://docs.microsoft.com/en-us/windows/mixed-reality/develop/install-the-tools)
    2. Create a new 3D Unity project and [install and configure the project using the Mixed Reality Toolkit](https://docs.microsoft.com/en-us/windows/mixed-reality/develop/unity/welcome-to-mr-feature-tool)
3. Fork and/or download the current version of Mista using the GitHub tools above. 
4. Copy all assets from your downloaded Mista project's `Assets` folder into your configured Unity MR project's `Assets` folder.

_TODO: Is there a more efficent way to implement the project?_

### Setting Up RobotStudio

[ABB Robot Studio Operating Manual](https://library.e.abb.com/public/58b48849b2c545f38cb1d85267032091/3HAC032104%20OM%20RobotStudio-en.pdf)

["RobotStudio Handbook" by Aprameya](https://www.ardavan.io/post/robotstudio-handbook)

_TODO: Not sure how to update this section. - Haley_

1. Ensure Robot Controller is functioning by viewing if Controller Status is green. Ensure you are connected to same network as Hololens. 

2. Ensure Network is setup correctly: 
    - From the tabs above, select "Controller". In the lefthand menu open the Configuration dropdown menu. Select Communication from the drop down menu. 
    - In the new window, select UDP Unicast Device
    - Referencing EGMdevice, ensure the following: Remote Address is set to the Hololens IP. Remote Port Number is set to Hololens Port. Local Port Number is set to port number that Hololens is sending to on local PC. 
    - If any changes are made to the UDP Unicast Device, Restart the robot controller to ensure the changes take place. Save project. 

3. Start Robot Controller EGM/UDP Server
    - From the tabs above, select "Controller". In the lefthand menu open the RAPID dropdown menu. Open the "T_ROB1" then "Module 1" menu items. Right click on the RAPID file "main". Select "Set Program pointer to Routine".
    - In the Controller Tools section above, select the drop down arrow under the "Flext Pendant" button. Select "OmniCore Flex Pendant". 
    - Once the Flext Pendant opens, click on the robot icon in the top right of the window. 
    - Ensure the Robot is in "Auto" mode. In the Motors section, set "Motors on".
    - Once the Motors have been turned on successfully, clock on the play button on the bottom right of the window. This action will start the EGM/UDP server. 
  
Note, if the robot is returned to home position while the Motor's are on, a guard state will be triggered, and the controller will have to restart in order to undo this guard state.
  
Notes to self:  Make sure to sign into the unity hub. Clarify the scene that needs to be opened first. 

### Building and Deploying the Application to Microsoft Hololens

1. [Build the Unity project for the Universal Windows Platform using Unity](https://docs.microsoft.com/en-us/windows/mixed-reality/develop/unity/build-and-deploy-to-hololens)
    1. [Building a project in Unity](https://docs.unity3d.com/560/Documentation/Manual/BuildSettings.html)
    2. **Do not choose to "Build and Run" your project.** Build your project by accessing the `Build Settings`.
2. [Deploy the project build to Hololens 2](https://docs.microsoft.com/en-us/windows/mixed-reality/develop/advanced-concepts/using-visual-studio?tabs=hl2)
    1. Connection to Hololens was done using a [remote connection](https://docs.microsoft.com/en-us/windows/mixed-reality/develop/advanced-concepts/using-visual-studio?tabs=hl2#remote-connection) over WiFi via a LAN network.
    2. [Microsoft Visual Studio](https://visualstudio.microsoft.com/downloads/) was used to build and deploy the Unity build to the Hololens as a MR application.

## :speech_balloon:	Contact the community
If you need our help or are interested in being part of our community, do not hesitate to send us a message:

- Felipe Fronchetti, Ph.D Student, [via Email](mailto:fronchettl@vcu.edu)
- Gabriella Graziani, Lab Assistant, [via Email](mailto:grazianige@vcu.edu)
- Miles Popiela, Lab Assistant, [via Email](mailto:popielamc@vcu.edu)
- Dr. David Shepherd, Principal Investigator, [via Email](mailto:shepherdd@vcu.edu)

---

Last Updated: May 24th, 2022 - Haley Currence
