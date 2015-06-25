using UnityEngine;
using System.Collections;

public class markerRotate : MonoBehaviour {
	float t = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if ( Input.GetKey(KeyCode.Space) == true ) {
			t += (float)0.1;
			if(t >= 0.7f){
				t = 15.0f;
				transform.Rotate(0.0f, 0.0f, t);
			}
		}
		else{
			t = 0;
		}
	}
}
