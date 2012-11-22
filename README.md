Finite State Machine Pattern in Unity (C# Code Sample)
=========
Author email: Gianluca.Delfino@gmail.com
<br>
website: www.DoorApps.com



Description
===========
<p>
Finite State Machine Pattern in Unity is a demo project part of a tutorial that can be found on www.DoorApps.com. It consists in a simple 
scene with a sphere representing the playing character, that can be moved with the arrow keys, and a cylinder representing 
the enemy "monster". The enemy is "asleep" till the sphere gets closer, then the cylinder wakes up and initiate the "attack" mode, 
which in this simple projects just means that it starts jumping.
</p>


<p>
The scope of this demo is to show how to implement the Finite State Machine Pattern in Unity. Ergo, it is what happens under the hood that matters.
The monster class uses composition to delegate the action performed in its Update method to a "state" object. The state object is swapped 
accordingly to what happens in the scene. For instance, the monster would start in the "Rest" state, but when the player crosses a certain trigger-collider
the state changes to "attackState". The states are classes inheriting from a IState interface. Indeed the most important thing here is that 
the "monster" class does not know anything about the state themselves, only knows their interface!
</p>

<p>
This implementation of the pattern is supposed to be extremely simple and just for demonstration purposes. For instance we chose to let the 
state themselves dictate when the state should change to something else. This is far from ideal for two reasons:
<ul>
<li> 
	The states in theory should not "know" anything about each other. Having the RestState class changing the state of the monster into AttackState
	not only does not make much sense, but most importantly implies that the state concrete classes are more coupled than they should. This should
	be avoided.
</li>
<li>
	Second, this implementation changes states invoking a method in the Monster class as in the following <code> ChangeState( new RestState ) </code>. 
	This means that we instantiate a new state object every time we change state, which just means we are in the hands of the 
	garbage collector that will have to take care of this. This too could be avoided having a StateManager class that instantiates all the states once
	and uses them in  <code> ChangeState( myRestState ) </code>. However this would create additional complications and obfuscate the part
	of the code that is actually relevant for the Finite State Machine pattern, which actually does not specify how to handle the state change.
</li>
</ul>

 In a more involved case, where memory and performance are important, one should take this into consideration and add the needed modifications
 to the code.
</p>

License
=======

This Program is released under the MIT license:

* http://www.opensource.org/licenses/MIT