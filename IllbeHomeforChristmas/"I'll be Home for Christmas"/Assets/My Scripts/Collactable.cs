using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; // Script indicates the assinged Collectable objects in Unity and adds its given value 

public class Collactable : MonoBehaviour // Class called Collectable, MonoBehavior is an inheritence
{
	public GameObject Enable_Disable; // Public variable to enable or disable objects, added to each collectable object in Inspector

	public int value; // Public variable, the value set in Inspector of object when collected

	public void Enable() 
	{
        Enable_Disable.SetActive (true); 
	}
    public void Disable() // Calls the collect method after object is clicked on and disabled 
	{
        Enable_Disable.SetActive (false); // Actually calling disable method from event triggers in Inspector
		GameManager.instance.Collect (value, gameObject); // Calls GameManager accessable name instance for collect function
                                                          // Gather value to Update score and UI also GameObject to disable it
	}
}
