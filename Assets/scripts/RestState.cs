using UnityEngine;
using System.Collections;

public class RestState : IState 
{
	/**
	 * Update plays the "Sleep" animation over and over
	 */  
	public virtual void Update( Monster _monster )
	{
		if( !_monster.animation.isPlaying ) 
		{
			_monster.animation.PlayQueued( "Sleep", QueueMode.CompleteOthers );
		}
	}
	
	/**
	 * On Trigger Enter plays the "GetUp" animation and changes state to "Attack"
	 */ 
	public virtual void OnTriggerEnter( Monster _monster )
	{
		_monster.animation.PlayQueued( "GetUp", QueueMode.CompleteOthers );
		_monster.ChangeState( new AttackState() );	
	}
	
	public virtual void OnTriggerExit( Monster _monster ){}
}	


