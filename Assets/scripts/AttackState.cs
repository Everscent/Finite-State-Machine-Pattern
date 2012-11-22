using UnityEngine;
using System.Collections;

public class AttackState : IState {
	
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
	 * On Trigger Exit plays the GetUp animation backwards and changes
	 * to RestState;
	 */ 	
	public virtual void OnTriggerExit( Monster _monster )
	{	
		_monster.animation.PlayQueued( "GoToSleep", QueueMode.CompleteOthers );				
		_monster.ChangeState( new RestState() );	
	}
	
}
