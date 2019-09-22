# WalkingSim
EGF Walking Sim


# Dev Update
Lots of work being done behind the scenes, a lot of testing Unity versions/compatability to try and get HDRP to work- some sacrifices here and there to keep up with visual quality. As it turns out HDRP in 2019 changed the way it handles screen space effects, and thus killing a lot of my post-processing in newer versions of Unity/HDRP. Did some tests with LWRP as a comprimise and built-in, but could not achieve close visual fedelity, also I found lower performance was found in LWRP/Built-In.

Aside from that work has been started on creating persistant systems that handle time passing in the game, objects remember placements, there's some foliage degeration over time based on player action and I have a work in progress weather system that changes each day the game is launched.

# Development screens

Unity 2019 Built-In Renderer - Very nice for sunsets, however, alter the sunset and the rest of the render looks quite poor, the lack of lighting across materials comparent to HDRP is very apparent.
![load road](https://i.imgur.com/dtrRc5I.png)

Day 1 in game - No one has walked through the path yet, weather has generated as a somewhat clear, sunny day.
![load road](https://i.imgur.com/JNp3mu0.png)

Day 5 in game - Overcast, later in the afternoon as it's getting dark - still need to tweak lighting settings - visble trail of where the player has walked through the environment previously.
![load road](https://i.imgur.com/M2yxdm0.png)

