using UnityEngine;
using System.Collections;

public class RestState : IState 
{
	public virtual void Update( Monster _monster )
	{
		if( !_monster.animation.isPlaying ) 
		{
			_monster.animation.PlayQueued( "Sleep", QueueMode.CompleteOthers );
		}
	}
	
	public virtual void OnTriggerEnter( Monster _monster )
	{
		_monster.animation.PlayQueued( "GetUp", QueueMode.CompleteOthers );
		_monster.ChangeState( new AttackState() );	
	}
	
	public virtual void OnTriggerExit( Monster _monster ){}
}	


