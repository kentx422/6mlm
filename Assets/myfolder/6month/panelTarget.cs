using UnityEngine;
using System.Collections;

public class panelTarget : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Color color = new Color (1.0f, 1.0f, 1.0f, 0.8f);
		this.renderer.material.color = color;
	}
	
	// Update is called once per frame
	void Update () {
		Color gray 	 = new Color (0.0f, 0.0f, 0.0f, 0.8f);
		Color white  = new Color (1.0f, 1.0f, 1.0f, 0.8f);
		Color red 	 = new Color (1.0f, 0.0f, 0.0f, 0.8f);
		Color green  = new Color (0.0f, 1.0f, 0.0f, 0.8f);
		Color blue 	 = new Color (0.0f, 0.0f, 1.0f, 0.8f);
		Color yellow = new Color (1.0f, 235.0f/255.0f, 4.0f/255.0f, 0.8f);

		if (Input.GetKey (KeyCode.A)) {
			if (Input.GetKeyDown(KeyCode.D))	{this.renderer.material.color = gray;}
			if (Input.GetKeyDown(KeyCode.W))	{this.renderer.material.color = white;}
			if (Input.GetKeyDown(KeyCode.R))	{this.renderer.material.color = red;}
			if (Input.GetKeyDown(KeyCode.G))	{this.renderer.material.color = green;}
			if (Input.GetKeyDown(KeyCode.B))	{this.renderer.material.color = blue;}
			if (Input.GetKeyDown(KeyCode.Y))	{this.renderer.material.color = yellow;}
		}
	}
}
