using UnityEngine;
using System.Collections;
using System.Net.Sockets;
using System.Text;

public class colorLED : MonoBehaviour {
	float time = 0.0f;
	float limit = 1.5f;
	int light = 50;
	// Use this for initialization
	void Start () {
		SocketALL();
		Color white  = new Color (1.0f, 1.0f, 1.0f, 0.8f);
		this.renderer.material.color = white;
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		GameObject cc = GameObject.Find("test");

		if(cc.renderer.material.color.a == 0.85f) {
		//if(true){
			if(cc.renderer.material.color.r == 1.0f ||
			   cc.renderer.material.color.g == 1.0f ||
			   cc.renderer.material.color.b == 1.0f)
			{
				light = 400;
			}
			if(cc.renderer.material.color.r == 0.8f ||
			   cc.renderer.material.color.g == 0.8f ||
			   cc.renderer.material.color.b == 0.8f)
			{
				light = 100;
			}
			if(cc.renderer.material.color.r == 0.6f ||
			   cc.renderer.material.color.g == 0.6f ||
			   cc.renderer.material.color.b == 0.6f)
			{
				light = 50;
			}
			if(cc.renderer.material.color.r == 0.4f ||
			   cc.renderer.material.color.g == 0.4f ||
			   cc.renderer.material.color.b == 0.4f)
			{
				light = 40;
			}
			if(cc.renderer.material.color.r == 0.2f ||
			   cc.renderer.material.color.g == 0.2f ||
			   cc.renderer.material.color.b == 0.2f)
			{
				light = 20;
			}
			if(cc.renderer.material.color.r == 0.0f &&
			   cc.renderer.material.color.g == 0.0f &&
			   cc.renderer.material.color.b == 0.0f)
			{
				light = 10;
			}
		}

		if(limit < time){
		//if(Input.GetKey(KeyCode.F)){
			if(this.renderer.material.color.r == 1.0f &&
			   this.renderer.material.color.g == 1.0f &&
			   this.renderer.material.color.b == 1.0f){
				SocketWhite();
			}
			else if(this.renderer.material.color.r == 1.0f &&
			        this.renderer.material.color.g == 0.0f &&
			        this.renderer.material.color.b == 0.0f){
				SocketRed();
			}
			else if(this.renderer.material.color.r == 0.0f &&
			        this.renderer.material.color.g == 1.0f &&
			        this.renderer.material.color.b == 0.0f){
				SocketGreen();
			}
			else if(this.renderer.material.color.r == 0.0f &&
			        this.renderer.material.color.g == 0.0f &&
			        this.renderer.material.color.b == 1.0f){
				SocketBlue();
			}
			else if(this.renderer.material.color.r == 1.0f &&
			        this.renderer.material.color.g == 235.0f/255.0f &&
			        this.renderer.material.color.b == 4.0f/255.0f){
				SocketYellow();
			}
			else if(this.renderer.material.color.r == 0.0f &&
			        this.renderer.material.color.g == 0.0f &&
			        this.renderer.material.color.b == 0.0f){
				SocketBlack();
			}
			else if(this.renderer.material.color.r == 1.0f &&
			        this.renderer.material.color.g == 30.0f/255.0f &&
			        this.renderer.material.color.b == 225.0f/255.0f){
				SocketSakura();
			}
			else if(this.renderer.material.color.r == 1.0f &&
			        this.renderer.material.color.g == 80.0f/255.0f &&
			        this.renderer.material.color.b == 30.0f/255.0f){
				SocketSun();
			}
			else{
			}
			time = 0.0f;
			
		}

	}

	void SocketALL(){
		string ipAddress = "172.20.11.68";
		int port = 14649;
		TcpClient client = new TcpClient(ipAddress, port);
		
		string str = "SET_ALL "+(light/2)+","+(light/2)+","+(light/2)+","+(light/2)+",\nUPDATE\n";
		byte[] tmp = Encoding.UTF8.GetBytes(str);
		
		NetworkStream stream = client.GetStream();
		
		stream.Write(tmp, 0, tmp.Length);
		client.Close();
	}
	void SocketWhite(){
		string ipAddress = "172.20.11.68";
		int port = 14649;
		TcpClient client = new TcpClient(ipAddress, port);

		string number = this.name;
		string str;
		str= "SET_SINGLE "+number+" "+(light/2)+","+(light/2)+","+(light/2)+","+(light/2)+",\nUPDATE\nUPDATE\n";
		byte[] tmp = Encoding.UTF8.GetBytes(str);
		
		NetworkStream stream = client.GetStream();
		
		stream.Write(tmp, 0, tmp.Length);
		client.Close();
	}
	void SocketRed(){
		string ipAddress = "172.20.11.68";
		int port = 14649;
		TcpClient client = new TcpClient(ipAddress, port);

		string number = this.name;
		string str;
		str= "SET_SINGLE "+number+" "+light+",0,0,0,\nUPDATE\nUPDATE\n";
		byte[] tmp = Encoding.UTF8.GetBytes(str);

		NetworkStream stream = client.GetStream();
		stream.Write(tmp, 0, tmp.Length);
		client.Close();
	}
	void SocketGreen(){
		string ipAddress = "172.20.11.68";
		int port = 14649;
		TcpClient client = new TcpClient(ipAddress, port);

		string number = this.name;
		string str;
		str= "SET_SINGLE "+number+" 0,"+light+",0,0,\nUPDATE\nUPDATE\n";
		byte[] tmp = Encoding.UTF8.GetBytes(str);
		
		NetworkStream stream = client.GetStream();
		stream.Write(tmp, 0, tmp.Length);
		client.Close();
	}
	void SocketBlue(){
		string ipAddress = "172.20.11.68";
		int port = 14649;
		TcpClient client = new TcpClient(ipAddress, port);

		string number = this.name;
		string str;
		str= "SET_SINGLE "+number+" 0,0,"+light+",0,\nUPDATE\nUPDATE\n";
		byte[] tmp = Encoding.UTF8.GetBytes(str);
		
		NetworkStream stream = client.GetStream();
		
		stream.Write(tmp, 0, tmp.Length);
		client.Close();
	}
	void SocketYellow(){
		string ipAddress = "172.20.11.68";
		int port = 14649;
		TcpClient client = new TcpClient(ipAddress, port);

		string number = this.name;
		string str;
		str= "SET_SINGLE "+number+" 0,0,0,"+light+",\nUPDATE\nUPDATE\n";
		byte[] tmp = Encoding.UTF8.GetBytes(str);
		
		NetworkStream stream = client.GetStream();
		
		stream.Write(tmp, 0, tmp.Length);
		client.Close();
	}
	void SocketBlack(){
		string ipAddress = "172.20.11.68";
		int port = 14649;
		TcpClient client = new TcpClient(ipAddress, port);

		string number = this.name;
		string str;
		str = "SET_SINGLE "+number+" 0,0,0,0,\nUPDATE\nUPDATE\n";
		byte[] tmp = Encoding.UTF8.GetBytes(str);
		
		NetworkStream stream = client.GetStream();
		
		stream.Write(tmp, 0, tmp.Length);
		client.Close();
	}
	void SocketSakura(){
		string ipAddress = "172.20.11.68";
		int port = 14649;
		TcpClient client = new TcpClient(ipAddress, port);
		
		string number = this.name;
		string str = "SET_SINGLE "+number+" 120,0,70,10,\nUPDATE\nUPDATE\n";
		byte[] tmp = Encoding.UTF8.GetBytes(str);
		
		NetworkStream stream = client.GetStream();
		
		stream.Write(tmp, 0, tmp.Length);
		client.Close();
	}
	void SocketSun(){
		string ipAddress = "172.20.11.68";
		int port = 14649;
		TcpClient client = new TcpClient(ipAddress, port);
		
		string number = this.name;
		string str = "SET_SINGLE "+number+" 120,0,0,80,\nUPDATE\nUPDATE\n";
		byte[] tmp = Encoding.UTF8.GetBytes(str);
		
		NetworkStream stream = client.GetStream();
		
		stream.Write(tmp, 0, tmp.Length);
		client.Close();
	}
	/*void LEDAllSwitch(){
		string ipAddress = "172.20.11.68";
		int port = 14649;
		TcpClient client = new TcpClient(ipAddress, port);
		string str = "SET_ALL 100,100,100,100,\n";
		byte[] tmp = Encoding.UTF8.GetBytes(str);
		NetworkStream stream = client.GetStream();
		stream.Write(tmp, 0, tmp.Length);
		client.Close();
	}
	void LEDSingleSwitch(){
		string ipAddress = "172.20.11.68";
		int port = 14649;
		TcpClient client = new TcpClient(ipAddress, port);
		string number = this.name;
		print (number);
		string str = "SET_SINGLE "+number+" 100,0,0,0,\nUPDATE\nUPDATE\n";
		byte[] tmp = Encoding.UTF8.GetBytes(str);
		NetworkStream stream = client.GetStream();
		stream.Write(tmp, 0, tmp.Length);
		client.Close();
	}*/
}