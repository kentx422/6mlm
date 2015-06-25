using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour {
	float flag = 0.0f;
	float time = 0.0f;
	float limit = 5.0f;
	//int color = 1;

	// Use this for initialization
	void Start () {
		collider.isTrigger = true;

	}
	
	// Update is called once per frame
	void Update () {

		//space

		
		/*if (Input.GetKeyDown(KeyCode.D))	color = 0;
		if (Input.GetKeyDown(KeyCode.W))	color = 1;
		if (Input.GetKeyDown(KeyCode.R))	color = 2;
		if (Input.GetKeyDown(KeyCode.G))	color = 3;
		if (Input.GetKeyDown(KeyCode.B))	color = 4;
		if (Input.GetKeyDown(KeyCode.Y))	color = 5;*/

		
	}
	
	private void OnTriggerStay(Collider other)
	{
	/*Color gray 	 = new Color (0.0f, 0.0f, 0.0f, 0.8f);
		Color white  = new Color (1.0f, 1.0f, 1.0f, 0.8f);
		Color red 	 = new Color (1.0f, 0.0f, 0.0f, 0.8f);
		Color green  = new Color (0.0f, 1.0f, 0.0f, 0.8f);
		Color blue 	 = new Color (0.0f, 0.0f, 1.0f, 0.8f);
		Color yellow = new Color (1.0f, 235.0f/255.0f, 4.0f/255.0f, 0.8f);
		if (flag == 1) 
		{
			if (color == 0)
				other.renderer.material.color = gray;
			else if (color == 1)
				other.renderer.material.color = white;
			else if (color == 2)
				other.renderer.material.color = red;
			else if (color == 3)
				other.renderer.material.color = green;
			else if (color == 4)
				other.renderer.material.color = blue;
			else if (color == 5)
				other.renderer.material.color = yellow;
			
		}*/
		time += Time.deltaTime;
		//if (Input.GetKey(KeyCode.Space))	flag = 1;
		if(time > limit)					flag = 1;
		else 								flag = 0;
		GameObject marker = GameObject.Find("bartop");
		//if(time > limit)
		if (flag == 1)
		{
			other.renderer.material.color = marker.renderer.material.color;
		}
	}
	private void OnTriggerExit(Collider other){
		time = 0;
	}
}
