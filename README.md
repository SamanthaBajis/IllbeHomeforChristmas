# IllbeHomeforChristmas
This repository contains a Unity 3D mobile application for iOS and Andriod devices called **_I'll be home for Christmas_**. It has been built and tested using the Google Cardboard Platform. The application is a maze game where the user must complete the maze in order to win  and to be prompted to restart the game. Along the way through the maze, the user is able to collect items (presents and stars) to increase their score to add to the fun of the experience! This was my capstone project for the Udacity VR Developer Nanodegree Program to present my skills and what I learned while developing mobile applications during the course.
<br />![screen shot 2018-02-09 at 1 09 25 pm](https://user-images.githubusercontent.com/35173600/36042633-8a9ecb74-0d9a-11e8-8d69-0a211ec999e3.png)

## Getting Started

### Prerequisites
The software you will need to download in order to build and run the game:
<br /> • The cross-platform engine [Unity 3D](https://unity3d.com/unity/qa/patch-releases/2017.1.0p4 "Unity 3D download") Patch Release 2017.1.0p4.
<br />
- For iOS builds, the latest version of [Xcode](https://developer.apple.com/download/ "Xcode 9.3 Beta").
- NOTE! You will need to have an [Apple ID](https://appleid.apple.com/account#!&page=create "Developer Account") in order to download Xcode and build for iOS
- NOTE! You will need to have an [Apple ID](https://appleid.apple.com/account#!&page=create "Developer Account") in order to download Xcode and build for iOS
-NOTE! For iOS, make sure to have the latest software version; 11 and up!
- For Andriod builds, [Andriod Studio](https://developer.android.com/studio/index.html "Andriod Studio download") and the [Java JDK 8](http://www.oracle.com/technetwork/java/javase/downloads/jdk8-downloads-2133151.html "JDK download").

### Installing
To build and run a copy of this application to your mobile device:
<br />
<br /> • On the SamanthaCBajis Github page, go to the green "Clone or download" button and click "Downland Zip"
<br />
<br /> • Once the zip file has loaded onto your desktop, double click the zip file to open. Navigate to the folder Assets > ChristmasMaze.unity and double click the scene to open it in Unity 3D
<br />
<br /> -NOTE! The scene may not be at the top of the folder. If not, you will have to scroll through the folder to find it. It will be titled exactly ChristmasMaze.unity with the Unity logo!-
<br />
<br /> After opening the scene in Unity 3D choose to build to either an iOS or Android mobile device.
<br />
1. For iOS builds.
   - Go to File > Build Settings and switch the platform to iOS (this could take a while) then click the Playing Settings button below that and you can change the bundle identifier, if you would like, before pressing Build and Run to then be prompted to name the build and save it (I usually save it to desktop so I can delete it later). 
     - The build will open in Xcode. Make sure to check your Apple ID is correct, the bundle identifier and the name of the application is what you would like it to be (you are also more than welcome to use the default name!) then press the play button in the upper left corner and the application will build and run directly to your iOS device!
2. For Andriod builds. 
   - First, go to the top left corner and click Unity > Preferences. Then, select External Tools in the list and add the locations of the Andriod Studio and Java JDk 8 in the correct section.
     - Afterwards, go to File > Build Settings and switch platform to Andriod (also could take a while to change to this platform) then click Playing Settings button below that and you can change the bundle identifier, if you would like, before pressing Build and Run to then be prompted to name the build and save it (I usually save it to desktop so I can delete it later). 

### Deployment
When building the application to your devices a few important things to note:
<br />
<br /> • In Player Settings you are able to not only change the name of the application and bundle identifier to whatever you would like, you can also keep it the way it is if you want, you can add a photo to be the icon for the application on your phone. It will be one of the first things to do in Player Settings, right after renaming the application!
<br /> • The Google VR SDK used in the game tracks your head movement. Meaning, whereever the phone is facing, the application will open and start you from that position. If you would like to be facing a certain why to play the game right after building it to your phone I would suggest facing your device in that direction and hold it horizontally so you can start the experience in a most comfortable position for you!

## How to play
The instructions to play the application "I'll be Home for Christmas" are very simple and fun!
![screen shot 2018-02-09 at 1 11 41 pm](https://user-images.githubusercontent.com/35173600/36042722-d2b82748-0d9a-11e8-9879-879e8527206b.png)
• After beginning the game, press the "Begin!" button on the start panel
<br />
<br /> • You can move throughout the maze by cicking on the sphereical waypoints, that will change from red to green as you gaze on them with  the Google Cardboard viewer, to guide you with the Cardbord headset clicker.
<br />
<br /> • While going through the maze you can pick up any presents or stars you see to increase your score-keep an eye out for the stars, they are worth more points!
<br />
<br /> • After reaching the end of the maze you can restart the experience by clicking the Restart button you will be prompted with in the house as you have made it home in time for Christmas!
<br />
<br /> ![screen shot 2018-02-09 at 1 13 56 pm](https://user-images.githubusercontent.com/35173600/36042827-288861f6-0d9b-11e8-8c95-74611514adb0.png)

# Authors
• Samantha Bajis - _Initial work_ - com.SamBajis

# Acknowledgments
To make this beautiful Christmas game possible asknowledgements go to:
<br /> 
<br /> • Udacity - coding for player movement machanic
<br /> 
<br /> • Google VR SDK- head tracking and interaction for player in game
