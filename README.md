# A Space Journey

This game was my thesis project to get my bachelor's degree in Computer Science. It is a 3D Game in Virtual Reality developed using Unity 2019 and C# for Android phones. The game uses a teleportation system to move and advance through the rooms. In order to advance, you need to go through the door with the correct answer; otherwise, you will be stuck and will have to go back. All the questions are related to space or the cosmos, and it has a timer to count how long it took you to answer all the questions.

Since this was my thesis project, I made the whole game myself. I conceptualized the idea, made the first sketches for the game and then designed the level in Unity using free resources. After that, I developed the code for the teleportation system, audio and timer. I ran many tests myself to fix minor bugs and some issues with the UI that could be noticed only after installing the game in the phone; for example, the game view in Unity showed that the timer was visible, but in the VR goggles it was not as noticeable due to final view differences resulting from the VR technology. I also used these tests to change the volume of the music, add some additional sound effects and made sure it was not too long so it does not cause any headaches to the users. After this I asked some friends to test it for feedback and made some changes to the colors and UI once again to make it more pleasing for the user.

I learned a lot from this project, especially thinking in a creative way - for example, most textbooks or guides described how to use physical colliders, while my project was using a pointer, so the collisions were different and the settings had to be modified as well. This caused some confusion when working with the teleportation system, but mostly when working with the timer. While the timer code was easy to implement, stopping it required using a stop function with a collider, which initially did not work as this would interfer directly with the teleportation. Solving this issue took multiple changes of code and tests in the game view. My proudest moment was when I decided to change the way the timer would stop: I created a cube and linked the timer script to it, but the UI was still in the canvas. Using this method, the destroy function would trigger when the pointer was aimed at the cube, and the script would stop running because the cube associated to it would have been destroyed. However, the total time would still show up after the timer was no longer running.

I think this demonstrates the highlight of my skills because of its complexity and the creative ways I had to use to solve issues which I could not resolve in the traditional way. While I had created text games in Java and a few small games using Arduino and C/C++, and I had also done some level design in Unity previously during my studies, it was not until this time that I got to combine all these things I learned and put them into execution to make a functional, complete and fun game using all stages of development. Throughout this project, I had to think outside the box to be able to solve any issues encountered while coding and setting up the project.