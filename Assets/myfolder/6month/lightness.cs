using UnityEngine;
using System.Collections;

public class lightness : MonoBehaviour {
	GameObject cc;
	GameObject mk;

	Color lightest	 = new Color (1.0f, 1.0f, 1.0f, 0.85f);
	Color lighter	 = new Color (0.8f, 0.8f, 0.8f, 0.85f);
	Color light	 	 = new Color (0.6f, 0.6f, 0.6f, 0.85f);
	Color dark 	 	 = new Color (0.4f, 0.4f, 0.4f, 0.85f);
	Color darker 	 = new Color (0.2f, 0.2f, 0.2f, 0.85f);
	Color darkest 	 = new Color (0.0f, 0.0f, 0.0f, 0.85f);

	float time = 0.0f;
	float limit = 0.5f;

	// Use this for initialization
	void Start () {
		if (this.name == "lightest") {
			this.renderer.material.color = lightest;
		}
		if (this.name == "lighter") {
			this.renderer.material.color = lighter;
		}
		if (this.name == "light") {
			this.renderer.material.color = light;
		}
		if (this.name == "dark") {
			this.renderer.material.color = dark;
		}
		if (this.name == "darker") {
			this.renderer.material.color = darker;
		}
		if (this.name == "darkest") {
			this.renderer.material.color = darkest;
		}

	}
	
	// Update is called once per frame
	void Update () {
		if (this.name == "lightest") {
			this.renderer.material.color = lightest;
		}
		if (this.name == "lighter") {
			this.renderer.material.color = lighter;
		}
		if (this.name == "light") {
			this.renderer.material.color = light;
		}
		if (this.name == "dark") {
			this.renderer.material.color = dark;
		}
		if (this.name == "darker") {
			this.renderer.material.color = darker;
		}
		if (this.name == "darkest") {
			this.renderer.material.color = darkest;
		}

		cc = GameObject.Find("test");
		mk = GameObject.Find("bartop");

		if(mk.renderer.material.color.r == 1.0f &&
		   mk.renderer.material.color.g == 1.0f &&
		   mk.renderer.material.color.b == 1.0f){
			lightest	 = new Color (1.0f, 1.0f, 1.0f, 0.85f);
			lighter		 = new Color (0.8f, 0.8f, 0.8f, 0.85f);
			light	 	 = new Color (0.6f, 0.6f, 0.6f, 0.85f);
			dark 	 	 = new Color (0.4f, 0.4f, 0.4f, 0.85f);
			darker 		 = new Color (0.2f, 0.2f, 0.2f, 0.85f);
			darkest 	 = new Color (0.0f, 0.0f, 0.0f, 0.85f);
		}
		
		if(mk.renderer.material.color.r == 1.0f &&
		   mk.renderer.material.color.g == 0.0f &&
		   mk.renderer.material.color.b == 0.0f){
			lightest	 = new Color (1.0f, 0.0f, 0.0f, 0.85f);
			lighter		 = new Color (0.8f, 0.0f, 0.0f, 0.85f);
			light	 	 = new Color (0.6f, 0.0f, 0.0f, 0.85f);
			dark 	 	 = new Color (0.4f, 0.0f, 0.0f, 0.85f);
			darker 		 = new Color (0.2f, 0.0f, 0.0f, 0.85f);
			darkest 	 = new Color (0.0f, 0.0f, 0.0f, 0.85f);
		}

		if(mk.renderer.material.color.r == 0.0f &&
		   mk.renderer.material.color.g == 1.0f &&
		   mk.renderer.material.color.b == 0.0f){
			lightest	 = new Color (0.0f, 1.0f, 0.0f, 0.85f);
			lighter		 = new Color (0.0f, 0.8f, 0.0f, 0.85f);
			light	 	 = new Color (0.0f, 0.6f, 0.0f, 0.85f);
			dark 	 	 = new Color (0.0f, 0.4f, 0.0f, 0.85f);
			darker 		 = new Color (0.0f, 0.2f, 0.0f, 0.85f);
			darkest 	 = new Color (0.0f, 0.0f, 0.0f, 0.85f);
		}

		if(mk.renderer.material.color.r == 0.0f &&
		   mk.renderer.material.color.g == 0.0f &&
		   mk.renderer.material.color.b == 1.0f){
			lightest	 = new Color (0.0f, 0.0f, 1.0f, 0.85f);
			lighter		 = new Color (0.0f, 0.0f, 0.8f, 0.85f);
			light	 	 = new Color (0.0f, 0.0f, 0.6f, 0.85f);
			dark 	 	 = new Color (0.0f, 0.0f, 0.4f, 0.85f);
			darker 		 = new Color (0.0f, 0.0f, 0.2f, 0.85f);
			darkest 	 = new Color (0.0f, 0.0f, 0.0f, 0.85f);
		}

		if(mk.renderer.material.color.r == 1.0f &&
		   mk.renderer.material.color.g == 235.0f/255.0f &&
		   mk.renderer.material.color.b == 4.0f/255.0f){
			lightest	 = new Color (1.0f, 1.0f, 0.0f, 0.85f);
			lighter		 = new Color (0.8f, 0.8f, 0.0f, 0.85f);
			light	 	 = new Color (0.6f, 0.6f, 0.0f, 0.85f);
			dark 	 	 = new Color (0.4f, 0.4f, 0.0f, 0.85f);
			darker 		 = new Color (0.2f, 0.2f, 0.0f, 0.85f);
			darkest 	 = new Color (0.0f, 0.0f, 0.0f, 0.85f);
		}

		if(mk.renderer.material.color.r == 0.0f &&
		   mk.renderer.material.color.g == 0.0f &&
		   mk.renderer.material.color.b == 0.0f){
			lightest	 = new Color (0.0f, 0.0f, 0.0f, 0.85f);
			lighter		 = new Color (0.0f, 0.0f, 0.0f, 0.85f);
			light	 	 = new Color (0.0f, 0.0f, 0.0f, 0.85f);
			dark 	 	 = new Color (0.0f, 0.0f, 0.0f, 0.85f);
			darker 		 = new Color (0.0f, 0.0f, 0.0f, 0.85f);
			darkest 	 = new Color (0.0f, 0.0f, 0.0f, 0.85f);
		}
	}

	private void OnTriggerStay(Collider other)
	{

			cc.renderer.material.color = this.renderer.material.color;
				
	}
	private void OnTriggerExit(Collider other){
		//time = 0;
	}
}
