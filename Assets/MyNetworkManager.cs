using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {

	public void MyStartHost() {
		StartHost ();
		Debug.Log (Time.timeSinceLevelLoad + " Starting host.");
	}

	override public void OnStartHost(){
		Debug.Log (Time.timeSinceLevelLoad + " Host started.");
	}

	override public void OnStartClient(NetworkClient myClient){
		Debug.Log (Time.timeSinceLevelLoad + " Client start requested.");
		InvokeRepeating ("PrintDots", 0f, 1f);
	}

	override public void OnClientConnect(NetworkConnection conn){
		Debug.Log (Time.timeSinceLevelLoad + " Client is connected to IP: " + conn.address);
		CancelInvoke ();	
	}

	void PrintDots(){
		Debug.Log (".");
	}
}
