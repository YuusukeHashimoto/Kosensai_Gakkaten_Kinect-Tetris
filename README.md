# Tetris-Kinect

Source code for a game produced by the Nara-Kosen Festival in 2017.

[Unity](https://unity.com/ja), a game engine, and [Kinect](https://developer.microsoft.com/ja-jp/windows/kinect/), a motion capture device, were used in the production of this game.

# Environment
Sorry, but the source code of the game made in 2017 at the Nara-Kosen Festival was uploaded in 2020, so the detailed environment and other details are unknown.

# How to play
The basic content is the same as the original Tetris. The only difference is that the blocks are controlled by the movement of your right arm.

## Basic posture
Stand upright, with your right arm pointing straight ahead!
Don`t use your left hand, so keep it on your hip.

## Basic operation
- 1) Right arm ***upward*** ⇒ Block rotates counterclockwise(There is no clockwise rotation).

- 2) Right arm to ***right*** => Block moves to the right.

- 3) Right arm to ***left*** ⇒ Block moves to left

- 4) Right arm ***downward*** ⇒ Block will fall faster

The image is that there are invisible control buttons around you, and you are operating them with your right hand. For example, if you keep your right hand pointing up, the button will stay pressed and keep rotating at regular intervals. If you want to rotate the block only once, point your arm upward and move it back forward at the earliest possible moment.

(Note 1) If you move your arm too fast, the Kinect camera may not be able to recognize it. If this happens, try playing slower while checking the movement of the girl on the right side of the game screen ([Unity-Chan](https://unity-chan.com/index.html)).

(Note 2) If you keep your right hand down, the blocks will fall at a fast speed! Make sure to return to the basic posture (right hand in front) after each block manipulation!

# For the staff

## 1) Step1
1) When the person who wants to play the game arrives, have him/her stand at the designated place (marked with tape).
At this point, explain the general outline of the game and how to operate it. When the staff presses the space button on the title screen, the game will start (but the blocks will not fall yet).

## 2) Step2
First, the Kinect will recognize the player's skeleton (sometimes it takes a while for the Kinect to recognize the player).
Once the player's skeleton is recognized, the avatar (Unity-chan) on the right side of the game screen will move in the same way as the player.
After confirming this, the staff member should click on the "GameStart" button. When you click the button, the blocks will start falling.
(If you click the GameStart button right after this screen appears (1 to 3 seconds), GameOver will occur for some reason, so don't click it right away.)
