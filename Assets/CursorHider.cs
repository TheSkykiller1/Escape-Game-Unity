using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorHider : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined; // keep confined in the game window
        Cursor.lockState = CursorLockMode.Locked;   // keep confined to center of screen
	}
	
	// Update is called once per frame
	void Update () {
		Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined; // keep confined in the game window
        Cursor.lockState = CursorLockMode.Locked;   // keep confined to center of screen
	}
}
