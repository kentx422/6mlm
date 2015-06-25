using UnityEngine;
using System.Collections;

public class testball: MonoBehaviour {
	GameObject pos;
	GameObject an,l,c,s,light,j;
	GameObject backS;
	float Distance = 1.0f;
	float Lange;
	float Q,R = 0;
	// Use this for initialization
	void Start () {
		pos = GameObject.Find("CameraRight");
		l = GameObject.Find("lange");
		an = GameObject.Find("angle");
		light = GameObject.Find("light12");
		j = GameObject.Find("lightJudge");
		c = GameObject.Find("Cube");
		s = GameObject.Find("Sphere");
		backS = GameObject.Find("backS");
	}
	
	// Update is called once per frame
	void Update () {
		Q = 360.0f - pos.transform.localEulerAngles.x;
		if(Q > 30 && Q < 150){
			/*l.renderer.enabled = true;
			c.renderer.enabled = true;
			s.renderer.enabled = true;
			backS.renderer.enabled = false;*/
			Lange = Distance / Mathf.Sin(Q*Mathf.PI/180.0f);
			//print (Q + "\t" + Lange+ "\t" +Mathf.Sin(Q*Mathf.PI/180.0f));
			TextMesh tm = (TextMesh)l.GetComponent(typeof(TextMesh));
			string now = (int)(Lange * 100.0f) +" [cm]";
			tm.text = now;
			TextMesh tan = (TextMesh)an.GetComponent(typeof(TextMesh));
			string noan = (int)Q+" [deg]";
			tan.text = noan;


		}
		else {
			//print ("error");
			TextMesh tm = (TextMesh)l.GetComponent(typeof(TextMesh));
			string now = " - - - [cm]";
			tm.text = now;
			TextMesh tan = (TextMesh)an.GetComponent(typeof(TextMesh));
			string noan = " - - - [deg]";
			tan.text = noan;

			//TextMesh tl = (TextMesh)light.GetComponent(typeof(TextMesh));
			//string nl = null;
			//tl.text = nl;
			/*l.renderer.enabled = false;
			c.renderer.enabled = false;
			s.renderer.enabled = false;
			backS.renderer.enabled = false;*/
		}

		//print (j.transform.right); 
		if(R > -100.0f){
			TextMesh tl = (TextMesh)light.GetComponent(typeof(TextMesh));
			string nl = light.name;
			tl.text = nl;
		}
		else{
			TextMesh tl = (TextMesh)light.GetComponent(typeof(TextMesh));
			string nl = null;
			tl.text = nl;
		}
	}

}
