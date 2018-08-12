using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColour : MonoBehaviour {
	public Color startColour;
	public Color mouseOverColour;
	bool mouseOver = false;

	public void OnMouseEnter(){
		mouseOver = true;
		GetComponent <Renderer> ().material.SetColor ("_Color", mouseOverColour);
	}
	public void OnMouseExit(){
		mouseOver = false;
		GetComponent<Renderer> ().material.SetColor ("_Color", startColour);
	}
}

