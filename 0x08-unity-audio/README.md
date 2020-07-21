<html>
<h1>Project: Unity Audio</h1>
<p><strong>In this project we'll review how Unity's audio system works and its importance when designing video games.</strong></p>
<body>
<li><strong>Task 0:</strong> In the MainMenu scene, create an empty GameObject named MenuSFX. Make button-rollover.ogg a child object of MenuSFX.

Add the button-rollover sound clip to all menu buttons (all three level select buttons, Options, Exit) so that when the player’s mouse hovers over a button, it plays the sound clip.</li>
<li><strong>Task 1:</strong> In the MainMenu scene, make button-click.ogg a child object of MenuSFX.

Add the button-click sound clip to all menu buttons (all three level select buttons, Options, Exit) so that when the player’s mouse hovers over a button, it plays the sound clip.

Save MenuSFX as a prefab inside the Prefabs folder.
<ul>
<li>The OptionsButton and ExitButton prefabs should be updated with the sound effect clips</li>
</ul>
</li>
<li><strong>Task 2:</strong> In the MainMenu scene, add Wallpaper as background music. It should start playing when the scene loads and stop when the player loads a different scene.

Inside the Audio folder, create an AudioMixer named MasterMixer. Inside MasterMixer, create a new Audio Mixer Group called BGM. Set the music’s Audio Mixer Group to BGM. By default, BGM audio levels should be at 0.00dB.</li>
<li><strong>Task 3:</strong> In the Level01 scene, add footstep sound clips to the Player so that when the Player is running, the sound plays in a loop until the Player stops running.
<ul>
<li>When the Player runs on a grassy platform, footsteps_running_grass should play</li>
<li>hen the Player runs on a stone platform, footsteps_running_rock should play</li>
<li>If you’ve used both types of platforms in your levels, find a way to trigger different sounds on different surfaces.</li>
<li>The footstep sounds should line up with the animation of the Player’s feet touching the ground</li>
<li>The footstep sounds should not play while the Player is jumping or falling</li>
</ul>
Create a new Audio Mixer Group named Running in MasterMixer and set the footsteps sound clips’ Audio Mixer Group to Running. By default this group’s audio level should be -20.00dB. Add filters to the group to make the sound fit the movement / terrain better.
</li>
<li><strong>Task 4:</strong> In the Level01 scene, add a landing sound clip to play when the player hits the ground from falling off the platforms and restarting. If the player lands on a grassy platform, footsteps_landing_grass should play. If the player lands on a stone platform, footsteps_landing_rock should play.

Create a new Audio Mixer Group named Landing in MasterMixer and set the sound clip’s Audio Mixer Group to Landing. By default this group’s audio level should be 2.00dB. Add filters to the group to make the fall sound more substantial.</li>
<li><strong>Task 5:</strong> In the Level01 scene, add CheeryMonday as background music. It should start playing when the level loads and stop when the player touches the WinFlag or returns to the MainMenu scene. The player sound effects should still play while the BGM plays.

Set the music’s Audio Mixer Group to BGM.</li>
<li><strong>Task 6:</strong> In the Level01 scene, add VictoryPiano as a win sting that plays once when the Player touches the WinFlag. The background music CheeryMonday should stop playing when VictoryPiano starts.

Set the Win music’s Audio Mixer Group to BGM.</li>
<li><strong>Task 7:</strong> Add ambient audio to at least one tree (birds) or at least one rock/grass/flower (crickets). This audio should be quiet or muted from a distance and grow louder as the player gets closer to the GameObject.

Create a new Audio Mixer Group named Ambience in MasterMixer and set birds and crickets Audio Mixer Group to Ambience. By default, Ambience‘s audio level should be 5.00dB.</li>
<li><strong>Task 8:</strong> Using Snapshots, create functionality so that when the Player pauses the game, the BGM should become muffled. (Check the playable demo to hear the desired effect.) When the player returns to the game, the sound should return to its original settings.</li>
<li><strong>Task 9:</strong> In the Options scene, make sure the OptionsButton and ExitButton prefabs are updated to have the button-rollover and button-click sound effect events applied.

In OptionsMenu.cs, script the BGMSlider so that when the slider’s value is changed by dragging the slider handle, the BGM audio decreases and increases from fully muted to max volume. These values should persist through all levels and when the game is quit and re-opened.</li>
<li><strong>Task 10:</strong> In the Options scene and OptionsMenu.cs, script the SFXSlider so that when the slider’s value is changed by dragging the slider handle, the SFX audio decreases and increases from fully muted to max volume. These values should persist through all levels and when the game is quit and re-opened.</li>
<li><strong>Task 11:</strong> Add music and sound effects to scenes Level02 and Level03, using the same Audio Mixer you created for Level01. Make sure your player sounds, options, etc. work in these scenes as well.
<ul>
<li>Level02 BGM: PorchSwingDays</li>
<li>Level03 BGM: BrittleRille</li>
</ul>
</li>
<li><strong>Task 12:</strong> Create three builds of all scenes above in the Builds directory.</li>
</body>
<h4>Credits:</h4>
<ul>
<li>
    <a href="https://assetstore.unity.com/packages/2d/textures-materials/sky/farland-skies-cloudy-crown-60004">Skyboxes: Farland Skies - Cloudy Crown</a>
</li>
<li>
    <a href="https://kenney.nl/assets/nature-pack-extended">Models: Kenney's Nature Pack Extended</a>
</li>
<li>
    <a href="https://kenney.nl/">Kenney</a>
</li>
<li>
    <a href="https://developer.oculus.com/downloads/package/oculus-audio-pack-1/">Oculus Audio Pack</a>
</li>
<li>
    <a href="https://mindful-audio.com/">Mindful Audio</a>
</li>
<li>
    <a href="http://creativecommons.org/licenses/by/3.0/">“Wallpaper”, “Cheery Monday” Kevin MacLeod (incompetech.com)
Licensed under Creative Commons: By Attribution 3.0</a>
</li>
</ul>
<footer>Made by: <strong><a href="https://github.com/DanielBaquero28">Daniel Baquero</a></strong></footer>
</html>