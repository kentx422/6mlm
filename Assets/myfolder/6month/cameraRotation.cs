using UnityEngine;
using System.Collections;

public class cameraRotation : MonoBehaviour {



	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		float move = 1.0f;

		if (Input.GetKey(KeyCode.W))	transform.Rotate(-move, 0.0f, 0.0f);
		if (Input.GetKey(KeyCode.S))	transform.Rotate(move, 0.0f, 0.0f);
		if (Input.GetKey(KeyCode.A))	transform.Rotate(0.0f, -move, 0.0f);
		if (Input.GetKey(KeyCode.D))	transform.Rotate(0.0f, move, 0.0f);
		if (Input.GetKey(KeyCode.Q))	transform.Rotate(0.0f, 0.0f, -move);
		if (Input.GetKey(KeyCode.E))	transform.Rotate(0.0f, 0.0f, move);


	}
}