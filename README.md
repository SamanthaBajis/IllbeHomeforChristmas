# IllbeHomeforChristmas
This repository contains a Unity 3D mobile application for iOS and Android devices called **_I'll be home for Christmas_**. It was built and tested using the Google Cardboard Viewer. The application is a maze game where the user must complete the maze in order to win and be prompted to restart the game. Along the way, the user is able to collect items to increase their score to add to the fun of the experience! This was my capstone project for the Udacity VR Developer Nanodegree Program. The experience is designed to make the user feel the emotion of Joy as they play. The project presents my skills and what I learned while developing mobile applications during the Udacity course.
<br />![screen shot 2018-02-09 a 1 09 25 pm](https://user-images.githubusercontent.com/35173600/36042633-8a9ecb74-0d9a-11e8-8d69-0a211ec999e3.png)

## Getting Started

### Prerequisites
The software you will need to download in order to build and run the game on a mobile device:
<br /> • The cross-platform engine [Unity 3D](https://unity3d.com/unity/qa/patch-releases/2017.1.0p4 "Unity 3D download") Patch Release 2017.1.0p4
<br />
- For iOS builds, the latest version of [Xcode](https://developer.apple.com/download/ "Xcode 9.3 Beta")
- NOTE! You will need to have an [Apple ID](https://appleid.apple.com/account#!&page=create "Developer Account") in order to download Xcode and build for iOS
- NOTE! Make sure to have the latest software version; 11 and up
- For Android builds, you need [Android Studio](https://developer.android.com/studio/index.html "Android Studio download") and the [Java JDK 8](http://www.oracle.com/technetwork/java/javase/downloads/jdk8-downloads-2133151.html "JDK download")

### Installing
To build and run a copy of this application to your mobile device:
<br />
<br /> • On the **_I'll be home for Christmas_** repository, go to the green "Clone or download" button and click "Download Zip"
<br />
<br /> • Once the zip file has loaded onto your desktop, double click the zip file to open. Navigate to the folder Assets > ChristmasMaze.unity and double click the scene to open it in Unity 3D
<br />
<br /> -NOTE! The scene may not be located at the top of the folder. If not, you will have to scroll through the folder to find it. It will be titled exactly ChristmasMaze.unity with the Unity logo-
<br />
<br /> After opening the scene in Unity 3D choose to build to either an iOS or Android mobile device
<br />
1. For iOS builds:
   - Go to File > Build Settings and switch the platform to iOS (this can take a while) then click the Player Settings button below that and with this open you can change the name of the application and bundle identifier, if you would like to change them, before pressing Build and Run to then be prompted to name the build and save it. (I usually save the build to my desktop so I can delete it later) 
     - The build will open in Xcode. Make sure to check your Apple ID is correct, the bundle identifier and the name of the application is what you would like it to be then press the play button in the upper left corner and the application will build and run directly to your iOS device.
2. For Android builds:
   - First, go to the top left corner and click Unity > Preferences. Then, select External Tools in the list and add the locations of Android Studio and Java JDK 8 in the correct section.
     - Afterwards, go to File > Build Settings and switch platform to Android (this can take a while to do) then click the Player Settings button below that and you can change the name of the application and bundle identifier, if you would like to change them, before pressing Build and Run to then be prompted to name the build and save it. The application will be built right to your Android device from Unity. 

### Deployment
When building the application to your phone a few important things to note:
<br />
<br /> • In Player Settings, you are able to not only change the name of the application and bundle identifier to whatever you would like you can also add a photo to be the icon for the application on your phone. It will be one of the first things you can do in Player Settings. Right under renaming the application.
<br /> • The Google VR SDK used in the game tracks your head movement. Meaning, wherever the phone is facing, the application will open and start your game from that position. If you would like to be facing a certain direction to play the game right after building to your phone I would suggest facing your device in that direction and hold it horizontally so you can start the experience in the most comfortable position for you.

## How to play
The instructions to play the application **_I'll be home for Christmas_** are very simple and fun!
![screen shot 2018-02-09 at 1 11 41 pm](https://user-images.githubusercontent.com/35173600/36042722-d2b82748-0d9a-11e8-9879-879e8527206b.png)
<br />
<br /> • After beginning the game, press the "Begin!" button on the panel in front of you
<br />
<br /> • You can move throughout the maze by clicking on the spherical waypoints with the viewer clicker. The waypoints will change from red to green as you gaze on them.
<br />
<br /> • While going through the maze you can pick up any presents or stars you see to increase your score. Keep an eye out for the stars, they are worth more points. Also, there will be a point where user must pick up trash on ground to help save the Earth. Would be a good idea to pick these up, as it is the right thing to do, but you will also get more points after doing so
<br />
<br /> • After reaching the end of the maze you can restart the experience by clicking the "Restart" button you will see while entering the house as you have finally made it home for Christmas!
<br />
<br /> ![screen shot 2018-02-09 at 1 13 56 pm](https://user-images.githubusercontent.com/35173600/36042827-288861f6-0d9b-11e8-8c95-74611514adb0.png)

# Authors
• Samantha Cayla Bajis - _Initial work_ - SamBajis

# Acknowledgments
To make **_I'll be home for Christmas_** possible:
<br /> 
<br /> • Udacity - Coding for player movement mechanic
<br /> 
<br /> • Google VR SDK- Head tracking, sound system and ability for the users interaction with the Google Cardboard Viewer
<br /> 
<br /> • Blender- Created cans, trash, and box the user will pick up towards the end of the experience using the 3D computer graphics software Blender
<br /> 
<br /> • Bretwalda Games - They created the Christmas 3D models used in experience. Such as the stars, presents and tree
