This project is still in its very early stage
### Game Design
https://docs.google.com/document/d/1rIBw64kN5TMKEaUFjj4fhWXK4hA4_mt3Lp2dtUbjsLk/edit?tab=t.1a2kkhah2j5a
### Card Shader
For better performance and easy management of the card prefab. I choose to use Sprite Renderer as the card base.

Since the ultimate goal is to make the game 3D, I want the cards to be 3D, aka both sides are rendered with the correct art. This is when the CardShader comes in, make it possible by using Branch node (as following this tut). I also decided to put as many elements in the shader as possible.

Then it comes to the effect icons and numbers of the cards which are children of the sprite renderer as sprite renderers and text meshes. These SR and TM are visible on both sides when rotating the card. So I use Cull in shader to help with this issue. These child SR and TM have materials generated from the shader that have Cull Off or Cull Back so that they only render on the front 
