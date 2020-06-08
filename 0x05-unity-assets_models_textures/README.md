<html>
<h1>Project: Unity Assests, Models & Textures</h1>
<p><strong>In this project we'll review how to work with Unity's assests, models and textures.</strong></p>
<body>
<li><strong>Task 0:</strong> Create a new Scene called Level01. Create a capsule GameObject called Player which will be a placeholder for this project.</li>
<li><strong>Task 1:</strong> In the Level01 scene, create a layout of floating platforms of different sizes and positions using only Unity Cube GameObjects, . Plan for a start point and an endpoint and create a path so that the Player can jump between them. The cubes will be placeholders for 3D models that we will import later on.</li>
<li><strong>Task 2:</strong> At the end point of the platforms, create a placeholder cylinder GameObject called WinFlag to designate the end of the path. Do not make WinFlag a child of any object. Later we will add scripting for when the Player reaches the WinFlag.</li>
<li><strong>Task 3:</strong> Create a new folder called Scripts. Inside that folder, create a new C# script called PlayerController and attach it to Player.</li>
<li><strong>Task 4:</strong> Position the Main Camera at an offset behind the player.</li>
<li><strong>Task 5:</strong> In the Scripts folder, create a new C# script called CameraController that allows the camera to follow the player. The script should also allow the player to rotate the camera on their own by moving the mouse, either by just moving the mouse or holding down right-click and dragging the mouse to move the camera.</li>
<li><strong>Task 6:</strong> Currently if the player falls off a platform, it falls infinitely. Edit the PlayerController and CameraController scripts so that if the player falls from a platform and can’t get to another platform, the player instead falls from the top of the screen onto the start position, causing the player to need to start from the beginning again.</li>
<li><strong>Task 7:</strong> Create a new Canvas and UI Text element that displays a timer on screen.</li>
<li><strong>Task 8:</strong> Create a script called Timer and attach to the Player. Timer should have a public Text variable called Timer Text for the TimerText Text object.

The timer should start at 0:00.00 and count up.</li>
<li><strong>Task 9:</strong> Create a script called WinTrigger and attach to WinFlag.

When the Player touches the WinFlag collider, the timer should stop and the text size should increase and the color should change to green. The recommended increased font size is 60 but the value is at your discretion as long as the size increase is noticeable to the user.</li>
<li><strong>Task 10:</strong> In the Unity Asset Store, find Farland Skies - Cloudy Crown, a free set of skyboxes. Add them to a folder called Skyboxes in the Assets/Materials folder in your 0x05-unity-assets project.</li>
<li><strong>Task 11:</strong> Download Kenney’s Nature Pack Extended. Import the asset package and place the files in a directory called Models. For the sake of organization, inside the Assets folder, create a new directory called Materials and move the materials in Models into Materials.

Replace your cube placeholders with the 3D models. The 3D models need mesh colliders otherwise the player cannot jump on them. Make sure the player can jump and move between platforms, that the distance and the player’s jump are reasonable, and that the player can reach the end from the starting point.</li>
<li><strong>Task 12:</strong> From the Nature Pack asset package in your Models folder, add trees, rocks, flowers, etc. to the platforms as you like. Organize your objects in your Hierarchy using empty GameObjects.

Keep in mind the placement of the objects so as not to block or hinder the player from being able to jump between platforms (unless that’s part of your design!). The player should also not be able to walk through rocks, trees, etc., but may walk through flowers, grass, etc.</li>
<li><strong>Task 13:</strong> Download this flag model. Place it in the Models directory. Add Flag to your scene and make it a child of the WinFlag GameObject. The pole of the flag should be positioned inside WinFlag‘s collider. Resize or reposition the collider if necessary.</li>
<li><strong>Task 14:</strong> Download this flag texture. Place it in a new directory called Textures.</li>
<li><strong>Task 15:</strong> Scenes in Build:
<ol>
<li>Level01</li>
</ol>
Create three builds of Level01 in a directory called Builds.
<ul>
<li>Windows and Linux builds should be set to x86_64 architecture</li>
</ul>
<strong>Build Folder Hierarchy:</strong>
<ul>
<li>Builds
<ul>
<li>Linux
<ul>
<li>Platformer_Data</li>
<li>Platformer.x86_64</li>
</ul>
</li>
<li>Mac
<ul>
<li>Platformer.app</li>
</ul>
</li>
<li>Windows
<ul>
<li>Platformer_Data</li>
<li>Platformer.exe</li>
<li>UnityPlayer.dll</li>
</ul>
</li>
</ul>
</li>
</ul>
</li>
</body>
<br>
<br>
<h4>Credits:</h4>
<ul>
<li>
    <a href="https://assetstore.unity.com/packages/2d/textures-materials/sky/farland-skies-cloudy-crown-60004#content">Skyboxes: Farland Skies - Cloudy Crown</a>
</li>
</ul>
<footer>Made by: <strong><a href="https://github.com/DanielBaquero28">Daniel Baquero</a></strong></footer>
</html>