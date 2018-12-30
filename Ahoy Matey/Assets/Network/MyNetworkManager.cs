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
        Debug.Log("Starting Host: " + Time.timeSinceLevelLoad);
        StartHost();
    }

    public override void OnStartHost() {
        Debug.Log("Host started at: " + Time.timeSinceLevelLoad);
    }

}
