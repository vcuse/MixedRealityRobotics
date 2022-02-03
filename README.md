# MixedRealityRobotics

Setup Robot Studio: 
1. Ensure Robot Controller is functioning by viewing if Controller Status is green. Ensure you are connected to same network as Hololens. 
2. Ensure Network is setup correctly: 
  - From the tabs above, select "Controller". In the lefthand menu open the Configuration dropdown menu. Select Communication from the drop down menu. 
  - In the new window, select UDP Unicast Device
  - Referencing EGMdevice, ensure the following: Remote Address is set to the Hololens IP. Remote Port Number is set to Hololens Port. Local Port Number is set to port number that Hololens is sending to on local PC. 
  - If any changes are made to the UDP Unicast Device, Restart the robot controller to ensure the changes take place. Save project. 
 3. Start Robot Controller EGM/UDP Server
  -From the tabs above, select "Controller". In the lefthand menu open the RAPID dropdown menu. Open the "T_ROB1" then "Module 1" menu items. Right click on the RAPID file "main". Select "Set Program pointer to Routine".
  -In the Controller Tools section above, select the drop down arrow under the "Flext Pendant" button. Select "OmniCore Flex Pendant". 
  -Once the Flext Pendant opens, click on the robot icon in the top right of the window. 
  -Ensure the Robot is in "Auto" mode. In the Motors section, set "Motors on".
  -Once the Motors have been turned on successfully, clock on the play button on the bottom right of the window. This action will start the EGM/UDP server. 
  
  Note, if the robot is returned to home position while the Motor's are on, a guard state will be triggered, and the controller will have to restart in order to undo this guard state.
