using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour {
	
	//public methods:
	/**
	 * Change State sets the state
	 * @param a class inheriting from the IState interface
	 */ 
	public void ChangeState( IState newState )
	{
		m_curState = newState;
	}	
	
	//private methods:
	/**
	 * Awake assings the RestState to the monster
	 */ 
	private void Awake()
	{
		m_curState = new RestState();
	}
	
	/**
	 * Update calls the current state Update()
	 */ 
	private void Update() 
	{
		m_curState.Update(this);
	}
	
	/**
	 * On Trigger Enter calls the current state OnTriggerEnter()
	 */ 
	private void OnTriggerEnter()
	{ 
		m_curState.OnTriggerEnter(this);	
	}
	
	/**
	 * On Trigger Exit calls the current state OnTriggerExit()
	 */ 
	private void OnTriggerExit()
	{
		m_curState.OnTriggerExit(this);	
	}
	
	//private members:
	private IState m_curState;
}
