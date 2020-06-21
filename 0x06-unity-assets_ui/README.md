<html>
<h1>Project: Unity Assests UI</h1>
<p><strong>In this project we'll review how to work with Unity's assests UI elements.</strong></p>
<body>
<li><strong>Task 0:</strong> Create two more Scenes in 0x06-unity-assets_ui. For each new scene, create a new path of platforms for the Player to navigate through.</li>
<li><strong>Task 1:</strong> Download the Google font “Changa” and place in a Changa folder into a new folder called Fonts in the Assets folder (the final path should be Assets/Fonts/Changa/<.ttf files>). All text should use this font, so change TimerText‘s font as well.

Download these images into a folder called UI in the Textures folder. Set their Texture Type to Sprite (2D and UI).

Create a new Scene called MainMenu.</li>
<li><strong>Task 2:</strong> Create a new Scene called Options.</li>
<li><strong>Task 3:</strong> Create a new C# script called MainMenu.cs. In the MainMenu scene, script the level buttons scene so that choosing Level01, Level02, or Level03 loads the corresponding scene.</li>
<li><strong>Task 4:</strong> Inside the Level01 Scene, create a new Canvas and using the image as a guide, create a pause screen.</li>
<li><strong>Task 5:</strong> Create a new C# script called PauseMenu.cs. Add a method to this script so that when the player presses Esc while playing the game, the game should pause and the PauseCanvas should become active. The timer should also pause.</li>
<li><strong>Task 6:</strong> In the PauseMenu and PauseMenu.cs, script the RestartButton so that it reloads the level scene that the player is currently on.</li>
<li><strong>Task 7:</strong> n the CameraController.cs script, add the ability to invert the Y axis.

Create a public bool called isInverted.</li>
<li><strong>Task 8:</strong> In Options and OptionsMenu.cs, script it so that checking the InvertYToggle in the menu and applying the changes reverses the camera/mouse movements in the level scene.</li>
<li><strong>Task 9:</strong> In the Level01 Scene, create a new Canvas and using the image as a guide, create a win screen.</li>
<li><strong>Task 10:</strong> Edit WinTrigger.cs so that when the player touches the flag, WinCanvas becomes active.</li>
<li><strong>Task 11:</strong> Create three builds of all scenes above in the Builds directory.</li>
</body>
<h4>Credits:</h4>
<ul>
<li>
    <a href="https://assetstore.unity.com/packages/2d/textures-materials/sky/farland-skies-cloudy-crown-60004">Skyboxes: Farland Skies - Cloudy Crown</a>
</li>
<li>
    <a href="https://kenney.nl/assets/nature-pack-extended">Models: Kenney's Nature Pack Extended</a>
</li>
</ul>
<footer>Made by: <strong><a href="https://github.com/DanielBaquero28">Daniel Baquero</a></strong></footer>
</html>