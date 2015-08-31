using UnityEngine;
using System.Collections;

public class MoveWall : MonoBehaviour 
{
	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.name =="trigger")
		{
			Destroy(other.gameObject);
				//Debug.Log("here");	
		}
		if(other.gameObject.name == "Wall Text")
		{
			Destroy(other.gameObject);
		}
		
	}
}
