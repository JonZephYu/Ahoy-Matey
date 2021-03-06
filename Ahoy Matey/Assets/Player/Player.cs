﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityStandardAssets.CrossPlatformInput;

public class Player : NetworkBehaviour {

    private Vector3 inputValue;

	// Use this for initialization
	void Start () {
		
	}

    public override void OnStartLocalPlayer() {
        //If local camera, enable camera
        //Camera component of camera disabled default
        Camera cam = GetComponentInChildren<Camera>();
        cam.enabled = true;

    }

    // Update is called once per frame
    void Update () {
        if (!isLocalPlayer) {
            return;
        }

        inputValue.x = CrossPlatformInputManager.GetAxis("Horizontal");
        inputValue.y = 0f;
        inputValue.z = CrossPlatformInputManager.GetAxis("Vertical");
        transform.Translate(inputValue);
    }
}
