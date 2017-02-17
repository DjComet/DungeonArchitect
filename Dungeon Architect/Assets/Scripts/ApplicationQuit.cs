using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationQuit : MonoBehaviour {

    public void Exit()
    {
		Debug.Log ("Exiting application");
        Application.Quit();
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
			Exit();
        }
	}
}
