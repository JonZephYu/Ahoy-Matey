using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class MyNetworkManager : NetworkManager {

    //private NetworkManager networkManager;

	// Use this for initialization
	void Start () {
        //networkManager = GetComponent<NetworkManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MyStartHost() {
        Debug.Log(Time.timeSinceLevelLoad + " Starting Host.");
        StartHost();
    }

    public override void OnStartHost() {
        Debug.Log(Time.timeSinceLevelLoad + " Host started.");
    }

    public override void OnStartClient(NetworkClient myClient) {
        Debug.Log(Time.timeSinceLevelLoad + " Client started request.");
        InvokeRepeating("PrintDots", 0f, 1f);
    }

    public override void OnClientConnect(NetworkConnection conn) {
        Debug.Log(Time.timeSinceLevelLoad + " Client is connected to IP: " + conn.address);
        CancelInvoke();
    }

    void PrintDots() {
        Debug.Log(".");
    }

}
