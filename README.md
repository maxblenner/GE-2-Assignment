# GE-2-Assignment

This is inspired by a scene in Mass effect 2

I could only get the steering and follow behaviours to work, so it is very basic. 

Video informaion:
- The SR2 Normandy is being chased through an asteroid field by hostile drones. 

Technical notes:
- I used navigation mesh or NavMesh in order to pathfind for the main ship (avoiding the asteroids) and the smaller drones chase after using regular transform position follows. 
- The reason the ship doesn't rotate is due to the rotations bugging out everytime I didn't lock them. Therefore I decided to lock the uprotation and rotation in navmesh.
- I coded normandy controller and enemy controller classes
- Normandy asset https://www.blendswap.com/blend/8489 
- Drones were made by me (simple shapes put together)

Here is the video of it running: 

[![Mass Effect 2 Space Chase](https://i9.ytimg.com/vi_webp/1gwCt6TTt_w/mqdefault.webp?time=1621518300000&sqp=CNzPmYUG&rs=AOn4CLALwrJQ4XF9fhK9cQzuDJc0rVmC2w)](https://youtu.be/1gwCt6TTt_w "Video of scene")

Thank you!
