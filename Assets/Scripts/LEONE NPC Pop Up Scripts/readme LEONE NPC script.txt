HOW TO MAKE THE LEONE NPC RISING SCRIPTS WORK

-

First, you want to create an empty GameObject and name it "NPC Cashier Trigger".

Then, after moving that GameObject to where you want the player to be when the NPC Cashier pops up and appears, give it a collider component.
Make sure that collider has the "Is Trigger" box checked, and adjust the bounds of the collider to make sure it is big enough for what you want.
Next, give the collider the "TriggerScriptForNPC" script. Some components still need to be plugged into it, but we will come back to that.


After that, take the NPC model that you want to pop out of the ground and put it under where you want it to pop up out of. Then give it the "RiseScriptNPC" script.
This script has a lot of public variables. Leave them all alone, except for the Speed one, the How Much one, and the Npc well. Drag the GameObject of the NPC that you attached this script to into the Npc well. For some reason GetComponent<> wasn't working, so we will just manually assign this. The speed and how much values can remain where they are for now, but may be tweaked later.

Next, go back to the NPC Cashier Trigger GameObject and drag the GameObject that has the collider for the player's Camera Rig into the well labeled "Player Col". It will be within the Trigger Script for NPC (Script) Component. After that, drag the NPC who has the "RiseScriptNPC" script on it into the Rise Script NPC well. This will make it so that that is the GameObject that that script is triggered on when the player's collider intersects with this collider. 

Finally, go back to the NPC model and add an audio source Component to it and give it the "noise NPC makes while giving food" audio. Turn off "Play on Awake" and tweak to your liking. 

After all that, test it and make sure it is how you want it. To make the NPC rise quicker or slower you can adjust the "Speed" float in the script on the NPC. additionally, this is currently set up to make the NPC rise until it is at or above 1 on the y axis. To change how much it rises, just edit the public How Much value to the desired value that you want. 

Enjoy!

- AL