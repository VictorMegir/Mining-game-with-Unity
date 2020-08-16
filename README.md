# Minecraft clone with Unity
A Minecraft-like game made with Unity game engine.
It is a game where the player mines cubes from the ground, places their own cubes and cylinders and jumps on top of cubes and cylinders to get to the top.

### Unity
* We have used Unity's basic 3D assets, such as the standard cude and cylinder.
* We have used Unity's raytracing and colliders for the cubes and cylinders.
* We have also used a basic first person camera, that moves with WASD, from the asset store.

### The Game
Basic information:
* The game begins with 3D grid with a floor made of cubes. The player inputs the size of the grid. They are spawned in the center of the grid.
* The player can use WASD to move and Space to jump.
* The player begins with 4 lives. If the player falls through a hole in the ground they lose a life. If they get to the top of the grid they gain a life and are returned to the starting position.
* Using the P key, the player can mine a cube they are looking at. Using the B key, the player can place a cube on top of the cube or cylinder they are looking at. Using the C key, the player can place a cylinder on top of the cube or cylinder they are looking at.
* The player gains more cubes that are available for placement as they mine the cubes from the ground. The cubes change color when mined. Blue cubes cannot be mined further. The player can mine teal cubes for cylinders. The teal cubes dissappear when minded creating holes on the floor from which the player can fall through.
