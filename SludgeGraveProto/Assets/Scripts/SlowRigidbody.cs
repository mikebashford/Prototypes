using UnityEngine;
using System.Collections;

public class SlowRigidbody : MonoBehaviour 
{
	public float slowFactor = 1.0f;
	private float oldSpeed;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter( Collider col )
	{
		NavMeshAgent agent = col.GetComponent<NavMeshAgent>();
		
		if( agent )
		{	
			agent.speed = agent.speed / slowFactor;
		}
	}
	
	void OnTriggerExit( Collider col )
	{
		NavMeshAgent agent = col.GetComponent<NavMeshAgent>();
		
		if( agent )
		{	
			agent.speed = agent.speed * slowFactor;
		}
	}
}
