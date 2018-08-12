using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour 
{
	public float rotatespeed;
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		gameObject.transform.Rotate (Vector3.back * Time.deltaTime * rotatespeed);
		
	}
}
