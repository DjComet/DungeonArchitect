using UnityEngine;
using System.Collections;

public abstract class Colour : MonoBehaviour {

	public abstract void UpdateBehaviour ();
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		UpdateBehaviour();
	}
}
