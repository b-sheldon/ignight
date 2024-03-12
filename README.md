# ignight
An immersive and insightful VR stargazing experience.

#### Ben, Cinay, Oscar, Noel, and Peipei

## Description 
ignight is an interactive VR experience where the user can learn more about zodiac constellations in a visually stunning and emotionally soothing environment. The player starts out in an observatory scene on top of a stylized platform. After the player presses a button, the platform floats into space. The player is able to look around at the constellations and see the constellation outlines appear. The player is then able to select a constellation by pointing and clicking it. This will make a 3D model of the constellation, with its symbol flying towards the player. This 3D model shows the relative real-life distances and positions of the stars from one another within the constellations. The player is able to grab and interact with the 3D constellation by turning it around and looking at it. Then, the player is able to swipe across the constellation to make it move to its respective position on the platform. When all six constellations are collected, all the constellations in the sky are drawn out while the constellations on the platform become stylized. This experience is intended to be both meditational and pedagogical, offering the player both visual stimulation and educational insight. 
## Responsibilities
### Developers:
#### Ben
- Created the Gaze Interactor with the Constellations (drawing/erasing as you look at/away from the constellations)
- Created the swipe interaction that moves and reorients the 3D models to their respective locations on the platform
- Created Scripts to manage which pedestals should be activated and which constellations should be drawn
- Created the Pose Detection Interaction to reset the scene (Two thumbs down)
- Sourced and integrated most of the sound effects into the scene
- Integrated the animations for the constellations drawing, end scene effects, platform/pedestal effects, and zodiac names
#### Noel
- Created the Ray Interaction with the Sky Constellations to cause the 3D Models to appear in the sky and shoot down to the platform
- Created the Grab Interaction with the 3D Models
- Created the Poke Interaction with the button and the animation of the platform rising out of the observatory
### Designers:
#### Cinay
- Added lighting to the observatory and baked the lights. 
- Textured the entire observatory and made custom designs for each model using Adobe Substance Painter.
- Edited the informational videos for the gameplay.
- Made the posters on the walls and made the poster for the game.
- Made the sparkle shader for the floor of the observatory and the cursor.
- Scavenged the correlated 3-D representation models for the six Zodiacs and edited some of them to fit the game style. 
- Created the observatory. 
- Modeled a monitor to display the informational videos.
- Created the six Zodiac name fonts, ignight title, and button press texts through Figma.
#### Oscar
- Originally modeled and animated the twelve Zodiac constellations in a 2-D space
- Remodeled and animated six of the twelve Zodiac constellations into an approximated 3-D model 
- Created particle effects for each of the six Zodiacs’ names through Vfx
- Drafted a cursor the player can see as they look up to the constellations 
- Created a firefly particle effect 
#### Peipei
- Modeled the six Zodiac signs on the platform
- Modeled and designed the whole platform
- Scavenged the correlated 3-D representation models for the six Zodiacs and edited some of them to fit the game style
- Made VFX effects (VFX trails that follow the signs from the sky, SDF VFX for all the 3d Zodiac models, VFX for the stars)
- Made Shaders (Shaders for the floating 3d Models, Fill Emission Shader for the rings, moon, and constellations on the platform)
- Animated the fill-in emission effect for the Torus, Constellations, and Moons on the platform
- Textured a few models in the observatory

## Scavenged Resources:
Meta All-In-One XR SDK
Skybox
Firefly Particle System Tutorial
Hand Pose Detection Tutorial
Sparkle Shader
Fade Audio Script
Particles Gather, Form, Explode Tutorial
Taurus Model
Leo Model
Cancer Model
Virgo Model
Gemini Model
Aries Model
Fill Emission Effect
Observatory Dome
SDF VFX
Stars VFX
Trail VFX and Zodiac Shader
Platform Center Design
Platform Zodiac Design
Platform Texture
