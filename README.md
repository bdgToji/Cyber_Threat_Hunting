# **Cyber Threat Hunting**
**A VR Game made in Unity to help players understand basics and a bit more about cyber security and online threats through interactive gameplay**

## Enabling a device simulator for playing/testing without a VR headset
The game is menat to be played with a VR headset along with 2 joysticks (Meta Quest 3, HTC Vive Pro 2, PSVR2, Valve Index).

However it can still be played without a headest, simply by going into the unity editor and enabling the **"Device Simulator"** component in the **scene menu** on the left side of the screen (in all 3 sceens)

## Project setup
The project is made using Unity's VR template, which includes the following packages:
* XR Interaction Toolkit (device simulator is in this package, which needs to be **imported** through the package manager window if making a new VR project)
* XR Plugin Management
* OpenXR Plugin
* Oculus XR Plugin
* XR Hands

## How to use the Device Simulator
* Moving around with the mouse moves the head (look around)
* To move the right hand, hold **space**
* To move the left hand, hold **shift**
* While controlling the hand, press **R** to change from rotation mode to translate mode of the hand, **mouse button 1** for interacting and hold **G** for grabbing
* While a hand is actovethe head will not move

## Gameplay
The premmis of the game is to go through the level while find answers to question related to cyber security and answering them corretly to gain item to progress.

The player has an **inventory** attached to this left hand that can be turend on or off by pressing the **menu** button on the left controller (dev sim. while holding shift press **M**)

The player will find a weapon in the starting area which uses bullets given by answering question.
One of the questions is a **SQL** related question which gives a ***SQL Injection*** needed to complete the game.
The player needs to find a ***data cube*** which will be used in the final room to gain access to a ***terminal*** to destroy the databse of the threat group using the ***SQL Injection***
