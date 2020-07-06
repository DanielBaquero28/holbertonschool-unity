<html>
<h1>Project: Unity Animation</h1>
<p><strong>In this project we'll review how Unity's animation system(Mecanim) works and is it such a powerful tool.</strong></p>
<body>
<li><strong>Task 0:</strong> In Level01 scene, disable Main Camera by clicking on the checkbox next to its name in the Inspector. Create a new Camera GameObject named CutsceneCamera. The camera should be facing the end flag.</li>
<li><strong>Task 1:</strong> DWith Intro01 open in the Animation tab, use keyframes to animate the CutsceneCamera‘s Position and Rotation so that the camera pulls back from the flag, panning over the length of the platforms, and stopping behind the player, ending in the position and rotation of the Main Camera.</li>
<li><strong>Task 2:</strong> Open the CutsceneCamera Animator in the Animator tab. Make sure that Entry has a transition to Intro.</li>
<li><strong>Task 3:</strong> Download this character model and import it into your Models folder. You may need to remap the materials and textures associated with the model. If you cannot find the materials and/or textures, extract them from the model’s Materials tab in the Inspector.</li>
<li><strong>Task 4:</strong> Edit CameraController.cs so that the camera still follows the player, but when the player turns, it does not change the orientation of the camera. The only rotation the camera should do is when the player moves the camera with the mouse.</li>
<li><strong>Task 5:</strong> All of the animations we’ll be using in this project are from Mixamo.</li>
<li><strong>Task 6:</strong> Download this Animation Clip and import it into your Animations folder. Change the settings so that they match Happy Idle‘s settings.

Drag the Running animation into the ty Animator and create transitions to and from the Happy Idle state. Name the transitions IdleToRunning and RunningToIdle accordingly.</li>
<li><strong>Task 7:</strong>Drag the Jump animation into the ty Animator and create transitions to and from the Happy Idle state as well as the Running state. Name the transitions IdleToJump, JumpToIdle, JumpToRunning, and RunningToJump accordingly.</li>
<li><strong>Task 8:</strong> Create a new Sub-state Machine called FallingDown. Create transitions to it from Running and Jump named RunningToFalling and JumpToFalling.</li>
<li><strong>Task 9:</strong> Add a new State called Falling Flat Impact. Create a transition from Falling to Falling Flat Impact called FallingToImpact. This animation should play when the player lands on the starting position after falling. This animation should play once and not repeat.</li>
<li><strong>Task 10:</strong> Add a new State called Getting Up. Create a transition from Falling Flat Impact to Getting Up named ImpactToGettingUp. Create a transition from the FallingDown sub-state to Idle named GettingUpToIdle. This animation should play after the Falling Flat Impact animation finishes. This animation should play once and not repeat.</li>
<li><strong>Task 11:</strong> Update the Level02 and Level03 scenes to have their own intro animations named Intro02 and Intro03 respectively. Replace the placeholder player with the animated model in each scene as well.</li>
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
</ul>
<footer>Made by: <strong><a href="https://github.com/DanielBaquero28">Daniel Baquero</a></strong></footer>
</html>