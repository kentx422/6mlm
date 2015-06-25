using UnityEngine;
using System.Collections;

public class Changecolor : MonoBehaviour {
	public string color = "";

	float time = 0.0f;
	float limit = 0.5f;
	// Use this for initialization
	void Start () {
		Color dark 	 = new Color (0.0f, 0.0f, 0.0f, 0.8f);
		Color white  = new Color (1.0f, 1.0f, 1.0f, 0.8f);
		Color red 	 = new Color (1.0f, 0.0f, 0.0f, 0.8f);
		Color green  = new Color (0.0f, 1.0f, 0.0f, 0.8f);
		Color blue 	 = new Color (0.0f, 0.0f, 1.0f, 0.8f);
		Color yellow = new Color (1.0f, 235.0f/255.0f, 4.0f/255.0f, 0.8f);
		Color sakura = new Color (1.0f, 90.0f/255.0f, 225.0f/255.0f, 0.8f);
		Color sun  	 = new Color (1.0f, 90.0f/255.0f, 50.0f/255.0f, 0.8f);

		if (this.name == "DARK") {
			this.renderer.material.color = dark;
		}
		if (this.name == "WHITE") {
			this.renderer.material.color = white;
		}
		if (this.name == "RED") {
			this.renderer.material.color = red;
		}
		if (this.name == "GREEN") {
			this.renderer.material.color = green;
		}
		if (this.name == "BLUE") {
			this.renderer.material.color = blue;
		}
		if (this.name == "YELLOW") {
			this.renderer.material.color = yellow;
		}
		if (this.name == "SAKURA") {
			this.renderer.material.color = sakura;
		}
		if (this.name == "SUN") {
			this.renderer.material.color = sun;
		}

	}
	
	// Update is called once per frame
	void Update () {
		Color dark 	 = new Color (0.0f, 0.0f, 0.0f, 0.8f);
		Color white  = new Color (1.0f, 1.0f, 1.0f, 0.8f);
		Color red 	 = new Color (1.0f, 0.0f, 0.0f, 0.8f);
		Color green  = new Color (0.0f, 1.0f, 0.0f, 0.8f);
		Color blue 	 = new Color (0.0f, 0.0f, 1.0f, 0.8f);
		Color yellow = new Color (1.0f, 235.0f/255.0f, 4.0f/255.0f, 0.8f);
		Color sakura = new Color (1.0f, 30.0f/255.0f, 225.0f/255.0f, 0.8f);
		Color sun  	 = new Color (1.0f, 80.0f/255.0f, 30.0f/255.0f, 0.8f);
		
		if (this.name == "DARK") {
			this.renderer.material.color = dark;
		}
		if (this.name == "WHITE") {
			this.renderer.material.color = white;
		}
		if (this.name == "RED") {
			this.renderer.material.color = red;
		}
		if (this.name == "GREEN") {
			this.renderer.material.color = green;
		}
		if (this.name == "BLUE") {
			this.renderer.material.color = blue;
		}
		if (this.name == "YELLOW") {
			this.renderer.material.color = yellow;
		}
		if (this.name == "SAKURA") {
			this.renderer.material.color = sakura;
		}
		if (this.name == "SUN") {
			this.renderer.material.color = sun;
		}


	}
	private void OnTriggerStay(Collider other)
	{
		GameObject top = GameObject.Find("bartop");
		GameObject bottom = GameObject.Find("barbottom");
		GameObject right = GameObject.Find("barright");
		GameObject left = GameObject.Find("barleft");
		time += Time.deltaTime;
		//if(Input.GetKey (KeyCode.Space)) {
		if(time > limit){
			top.renderer.material.color = this.renderer.material.color; 
			bottom.renderer.material.color = this.renderer.material.color;  
			right.renderer.material.color = this.renderer.material.color;  
			left.renderer.material.color = this.renderer.material.color;
		}
	}
	private void OnTriggerExit(Collider other){
		time = 0;
	}
}
