using UnityEngine;
using System.Collections;

public class blocMovement : MonoBehaviour {
	public int objVel = 10;
	// Use this for initialization

	void Start () {
	}
	// Update is called once per frame
	void Update () {
		if (transform.localPosition.y>0) {
			transform.Translate (Vector3.down * objVel * Time.deltaTime);
		}
	}
}
