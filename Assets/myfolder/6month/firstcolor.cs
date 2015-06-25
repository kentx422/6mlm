using UnityEngine;
using System.Collections;

public class firstcolor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Color color = new Color (0.2f, 0.2f, 0.2f, 1.0f);
		this.renderer.material.color = color;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0.5f, 0.3f, 0.7f);
	}
}
