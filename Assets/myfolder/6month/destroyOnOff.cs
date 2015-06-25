using UnityEngine;
using System.Collections;

public class destroyOnOff : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKey(KeyCode.LeftShift) == true ) renderer.enabled = true;
		if ( Input.GetKey(KeyCode.LeftControl) == true ) renderer.enabled = false;
	}

}
