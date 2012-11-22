using UnityEngine;
using System.Collections;

public class AttackState : IState {

	/**
	 * Update plays the "Attack" animation over and over..
	 */ 
	public virtual void Update( Monster _monster )
	{ 
		if( !_monster.animation.isPlaying ) 
		{
			_monster.animation.PlayQueued( "Attack", QueueMode.CompleteOthers );
		}
	}
	
	public virtual void OnTriggerEnter( Monster _monster )
	{
		//does nothing
	}
	
	/**
	 * On Trigger Exit plays the "GoToSleep" animation and changes
	 * to "RestState";
	 */ 	
	public virtual void OnTriggerExit( Monster _monster )
	{	
		_monster.animation.PlayQueued( "GoToSleep", QueueMode.CompleteOthers );				
		_monster.ChangeState( new RestState() );	
	}
}
