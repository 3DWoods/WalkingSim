# WalkingSim
EGF Walking Sim


# Day 9
Shaders are still broken, unity crashing -a lot-, -a lot a lot-. Somethings just not great in 2018, but I can't narrow it down. 

Terrain has been completed, originally I was going to use PolyBrush (Unity's newly aquired tool) to do object scattering and vertex painting, however- it's just incredibly awkward to work with, causes way too many issues, and simply cannot work with meshses as large as the environment terrain. I came across [this tool called Object2Terrain](https://lmhpoly.com/convert-mesh-to-unity-terrain/), which converts mesh objects into unity terrain (allowing me to then use landscape painting tools, over PolyBrush) which ends up being better as PolyBrush has a limit of 4 textures per surface, where as Unity Terrain is unlimited(? Haven't checked how much it can handle, but I've slotted in 6 textures so far and have had no issue painting with all of them together).

Now it's just going to be a few incredibly long days of detailing the environment out, and then I'll be moving onto designing and implementing my environmental game feel mechanics.

TODO:
And urgently; make a build, make sure it's running. I've added in so many tools and assets the past few weeks I have no idea if it builds successfully.

# Development screens

Terrian completed
![load road](https://i.imgur.com/pJBD6OZ.png)

The load road of detailing
![load road](https://i.imgur.com/ukGGjTk.png)


