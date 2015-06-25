using UnityEngine;
using System.Collections;
using System.Net.Sockets;
using System.Text;

public class test1 : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		SocketALL ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Z)){
			if (this.renderer.material.color.r == 1.0f && 
			    this.renderer.material.color.g == 0.0f &&
			    this.renderer.material.color.b == 0.0f) {
				print ("a");
				SocketRed();
			}
		}
		if (Input.GetKey (KeyCode.LeftAlt)) {
			print ("alt");}
		if (Input.GetKey (KeyCode.S)) {
			print ("S");
			SocketALL();
		}
	}
	void SocketALL(){
		string ipAddress = "172.20.11.68";
		int port = 14649;
		TcpClient client = new TcpClient(ipAddress, port);
		
		string str = "SET_ALL 100,100,100,100,\nUPDATE\n";
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
		string str = "SET_SINGLE "+number+" 100,100,100,100,\nUPDATE\n";
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
		string str = "SET_SINGLE "+number+" 200,0,0,0,\nUPDATE\n";
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
		string str = "SET_SINGLE "+number+" 0,200,0,0,\nUPDATE\n";
		byte[] tmp = Encoding.UTF8.GetBytes(str);
		
		NetworkStream stream = client.GetStream();
		print ("green");
		stream.Write(tmp, 0, tmp.Length);
		client.Close();
	}
	void SocketBlue(){
		string ipAddress = "172.20.11.68";
		int port = 14649;
		TcpClient client = new TcpClient(ipAddress, port);
		
		string number = this.name;
		string str = "SET_SINGLE "+number+" 0,0,200,0,\nUPDATE\n";
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
		string str = "SET_SINGLE "+number+" 0,0,0,200,\nUPDATE\n";
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
		string str = "SET_SINGLE "+number+" 0,0,0,0,\nUPDATE\n";
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