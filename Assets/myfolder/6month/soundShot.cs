using UnityEngine;
using System.Collections;

public class soundShot : MonoBehaviour {

	public AudioClip audioClip;
	AudioSource audioSource;
	float t = 0;
	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = audioClip;
	}

	// Update is called once per frame
	void Update () {
		if ( Input.GetKey(KeyCode.Space) == true ) {
			// Torigger

			if(t == 0.0f) audioSource.Play();
			else if(t >= 1.0f) audioSource.Play();

			t += 0.1f;
		}
		else{
			t = 0;
		}
	}
}
