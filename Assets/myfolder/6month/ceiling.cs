using UnityEngine;
using System.Collections;

public class ceiling : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Color color = new Color (0.9f, 0.9f, 0.9f, 0.2f);
		this.renderer.material.color = color;
	}
}
