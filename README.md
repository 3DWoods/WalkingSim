# WalkingSim
EGF Walking Sim


# Day 10
Worries about a build compiling were true, though managed to get the build running, just needed to add the clouds shader to be prerendered.

I've used the [Unity split terrain script](http://kostiantyn-dvornik.blogspot.com/2013/12/unity-split-terrain-script.html) tool created by [Kostiantyn Dvornik](http://kostiantyn-dvornik.blogspot.com/2013/12/unity-split-terrain-script.html)](http://kostiantyn-dvornik.blogspot.com) to split my large environment scene into smaller chunks, this will allow me to focus each day into filling out an area of terrain with trees, and details, and fine tuning the terrain mesh. This is also a good optimisation step as it allows me further control of how much of the terrain needs to be visible at any given time. 

I also found out Unity's terrain painting tool does have a limit of 8 layers, that's up by 4 from PolyBrush, but it was another reason to split the terrain into chunks, as not all areas are going to utilise the same texture sets, so swapping them out per terrain chunk will be another benefit of splitting.

For now I'm just focusing on filling out each of these terrain split chunks, I've subdivided the main terrain twice breaking it into a total of 16 chunks which need to be detailed, ideally these will take around half a day to a day each to fill.

Also upgraded HDRP pipeline to 4.10 to support R.A.M. River Auto Material for rivers and waterfall support.

TODO:
A few weeks ago I also upgraded my computer case (needed a bigger case to fit a new AIO as mine was on the brink of death, seriously, 90c importing files into Unity with the old one) but the drawback was the new case only fits  2 standard HDDs, my old case has 5 - A bunch of my old shaders I was developing for grass and wind effects are unfortunately on one of the HDDs that didn't make it into the new case, so I'll need to get around to pulling my PC apart and copying over those important files, a bit time consuming to be sure.

# Development screens

Opening section
![load road](https://i.imgur.com/MGi8Hed.png)

Hill section
![load road](https://i.imgur.com/AqzTd9s.png)


