using UnityEngine;
using System.Collections;

public class angle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		print (360.0f - this.transform.localEulerAngles.x);
	}
}
