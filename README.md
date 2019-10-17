# WalkingSim
EGF Walking Sim


# Dev Update
Path system update

- Moved from non-dynamic zone alterations to dynamic prototype.

Implemented a dirty unoptimised system that alters the patch of grass prefab currently under the player character, this allows for players to pass over the grass in the scene and alter it dynamically throughout play.

[URGENT]
TODO:
Optimise: using GetComponent to get the player position each frame and it's tanking frame rate. (running at 10FPS, down from 40)
Send to persistant data manager - This dynamic system is not yet part of the persistant data manager, and won't be saved each time the game launches.

# Development screens

Prototype of a path left behind by walking through the tall grass.
![load road](https://i.imgur.com/1SXgNNI.png)


