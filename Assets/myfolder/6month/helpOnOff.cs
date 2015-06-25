using UnityEngine;
using System.Collections;

public class helpOnOff : MonoBehaviour {
	Vector3 pos;
	// Use this for initialization
	void Start () {
		renderer.enabled = true;
		pos = this.transform.localPosition;
	}


	// Update is called once per frame
	void Update () {
		if ( Input.GetKey(KeyCode.J)){
			renderer.enabled = false;
			transform.localPosition = new Vector3(10000.0f, 10000.0f, 10000.0f);
		}
		if (Input.GetKey (KeyCode.H) == true) {
			renderer.enabled = true;
			transform.localPosition = pos;
		}
	}
}
