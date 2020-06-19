# MixAndJam-KingdomSelect

![Preview](Preview.gif)

I built this project following along with the excellent Mix and Jam tutorial, ["Mario Odyssey's Kingdom Select"](https://youtu.be/sCK4u5ol3xw).

Notes:
- I didn't instantiate the prefabs for the kingdoms from the code (as the original tutorial does) because I wanted the ability to place them at specific points and not have to copy the coordinates over into the controller.
- I used [Vivek Tank's GamaSutra tutorial](https://www.gamasutra.com/blogs/VivekTank/20180806/323709/How_to_work_with_Bezier_Curve_in_Games_with_Unity.php) to create the quadratic Bezier curves between the kingdoms. In this example, I used an object for each curve, but, of course, you could draw all the curves using only a single game object.
- For the UI and tab system, I used a modified version of Game Dev Guide's [Creating a Custom Tab System in Unity](https://youtu.be/211t6r12XPQ).
- For the Earth itself, I used Jeff Johnson's [Free Earth Planet](https://assetstore.unity.com/packages/vfx/shaders/free-earth-planet-the-best-planet-shader-in-the-asset-store-56841) from the Asset Store.
- The skybox is Pulsar Byte's free [Starfield Skybox](https://assetstore.unity.com/packages/2d/textures-materials/sky/starfield-skybox-92717) also on the Asset Store.
- Camera animation is done with [DOTween](http://dotween.demigiant.com/) from DemiGiant.
- No UI animation, because... I am not yet sure how to use DOTween to animate the UI without shuffling around the objects in my layout groups.