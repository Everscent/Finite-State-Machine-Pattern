using UnityEngine;
using System.Collections;

public interface IState 
{	
	void Update( Monster _monster );
	void OnTriggerEnter( Monster _monster );
	void OnTriggerExit( Monster _monster );
}
