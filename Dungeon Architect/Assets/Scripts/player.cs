using UnityEngine;
using System.Collections;

	/// <summary>
	/// class that controls the movement and behaviour of the player
	/// </summary>
		
public class player : MonoBehaviour {
	
	public float velocidadDespzamiento; 
	public float velocidadGiro; 

	void Start(){
	}

	void Update ()  
	{ 
		if (Input.GetKey(KeyCode.UpArrow)) { 
			this.transform.Translate(Vector3.forward * velocidadDespzamiento); 
		} 

		if (Input.GetKey(KeyCode.DownArrow)) { 
			this.transform.Translate(Vector3.back * velocidadDespzamiento); 
		} 

		if (Input.GetKey(KeyCode.LeftArrow)) { 
			this.transform.Rotate(Vector3.down * velocidadGiro);  
		} 

		if (Input.GetKey(KeyCode.RightArrow)) { 
			this.transform.Rotate(Vector3.up * velocidadGiro);  
		}
	} 
} 

