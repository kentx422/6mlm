using UnityEngine;
using System.Collections;

public class allChange : MonoBehaviour {
	GameObject[] t = new GameObject[30];
	float time = 0.0f;
	float limit = 0.8f;
	// Use this for initialization
	void Start () {
		collider.isTrigger = true;
		Color white  = new Color (1.0f, 1.0f, 1.0f, 0.8f);
		this.renderer.material.color = white;
		for(int i = 0; i<29; i++){
			string I = i.ToString();
			t[i] = GameObject.Find(I);
			t[i].renderer.material.color = white; 
		}
	}
	
	// Update is called once per frame
	void Update () {
		for(int i = 0; i<29; i++){
			string I = i.ToString();
			t[i] = GameObject.Find(I);  
		}
	
	}
	private void OnTriggerStay(Collider other)
	{
		time += Time.deltaTime;
		//if (Input.GetKey (KeyCode.Space)) {
		if(time > limit){
				for (int i = 0; i<29; i++) {
						t[i].renderer.material.color = this.renderer.material.color;
				}
		}

	}
	private void OnTriggerExit(Collider other){
		time = 0;
	}
}
