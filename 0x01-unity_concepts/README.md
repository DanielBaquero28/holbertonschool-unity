<html>
<h1>Project: Unity Concepts</h1>
<p><strong>In this project we'll dive in on Unity, we'll start reviewing the basic GameObject manipulations and the best way to do them.Take a look at it.</strong></p>
<body>
<li><strong>Task 0:</strong> Create a new 3D Unity project called 0x01-unity_concepts. Save your new scene as 0-floor. Create a new Cube GameObject named Floor with the following Transform properties:
<ul>
<li>Position: X: 0, Y: 0, Z: 0</li>
<li>X: 0, Y: 0, Z: 0</li>
<li>X: 16, Y: 0.5, Z: 16</li>
</ul>
</li>
<li><strong>Task 1:</strong> Duplicate 0-floor by selecting the scene in the Project window and either Edit > Duplicate from the Toolbar or CTRL / CMD + D. Rename the scene 1-ball and open it. Create a new Sphere GameObject named Ball with the following Transform properties:
<ul>
<li>Position: X: 0, Y: 8, Z: 0</li>
<li>X: 0, Y: 0, Z: 0</li>
<li>X: 1.5, Y: 1.5, Z: 1.5</li>
</ul>
</li>
<li><strong>Task 2:</strong> Duplicate 1-ball, rename it 2-colors, and open it. Create a Materials folder in the Project window, then create a new material named floor. In the Inspector window, change the Albedo color to any color you like using the color picker. Assign the material to the Floor GameObject.
<br>
Create a second new material named ball. Change the material color and assign the new material to the Ball GameObject.</li>
<li><strong>Task 3:</strong> Duplicate 2-colors, rename it 3-gravity, and open it. Add a Rigidbody Component to the Ball GameObject. Press Play to see what happens. Wouldn’t it be better if the ball bounced when it fell?
<br>
Create a new folder in the Project window named Physic Materials and create a new Physic Material called bounce. Feel free to edit the material’s settings to get an idea of what the different settings affect. Add the bounce material to the Ball’s Sphere Collider. Press Play. For this task, your final bounce material settings should be:
<ul>
<li>Bounciness: 0.8</li>
<li>Bounce Combine: Maximum</li>
</ul>
</li>
<li><strong>Task 4:</strong> Duplicate 3-gravity, rename it 4-prefab, and open it. Create a new folder named Prefabs. Create a prefab from the Ball inside the new folder, then, using the prefab, add four more instance of the Ball to the scene. Position and scale them any way you like.</li>
<li><strong>Task 5:</strong> Duplicate 4-prefab, rename it 5-more_colors, and open it. Change the colors of each ball so they are different hex colors as defined below. New materials should be named as listed below. You cannot use scripts in this task.
<ul>
<li>ball-red : FF0000FF</li>
<li>ball-blue : 0000FFFF</li>
<li>ball-green : 00FF00FF</li>
<li>ball-white : FFFFFFFF</li>
<li>ball-black : 000000FF</li>
</ul>
<p>Take a look at the Hierarchy window. Having a bunch of GameObjects with the same name is hard to navigate, right? It’s important to clearly name your GameObjects and assets, especially when working with others in the same project. Rename each Ball GameObject in your scene with their color name.</p>
<ul>
<li>Red Ball</li>
<li>Blue Ball</li>
<li>Green Ball</li>
<li>White Ball</li>
<li>Black Ball</li>
</ul>
</li>
<li><strong>Task 6:</strong> Duplicate 5-more_colors, rename it 6-tags, and open it. Add a tag to all Ball objects called Obstacles.</li>
<li><strong>Advanced Task 0:</strong> Duplicate 6-tags, rename it 100-textures, and open it. Create a new instance of Ball named Textured Ball and add a texture to it. Your texture asset should be in a folder named Textures and your new material should be called ball-texture.</li>
</body>
<br>
<br>
<footer>Made by: <strong><a href=“https://github.com/DanielBaquero28”>Daniel Baquero</a></strong></footer>
</html>