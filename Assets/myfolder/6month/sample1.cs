using UnityEngine;
using System.Collections;
using System.Text;
using System;
using System.Net.Sockets;
using UnityEngine;
using System.Collections;
using System.Text;
using System;
using System.Net.Sockets;

public class sample1 : MonoBehaviour {
	public string color = "white";
	public int number = 0;
	// Use this for initialization
	void Start () {
		SocketALL();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.X)){
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
			else{
			}
			
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
		
		string str = "SET_SINGLE "+number+" 0,0,0,0,\nUPDATE\n";
		byte[] tmp = Encoding.UTF8.GetBytes(str);
		
		NetworkStream stream = client.GetStream();
		
		stream.Write(tmp, 0, tmp.Length);
		client.Close();
	}
}
