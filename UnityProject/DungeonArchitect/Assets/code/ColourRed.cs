using UnityEngine;
using System.Collections;

public class ColourRed : Colour {

	public override void UpdateBehaviour(){
		transform.Rotate (0, 20 * Time.deltaTime, 0);
		transform.position += Vector3.up * 10.0f * Time.deltaTime;

	}
}
