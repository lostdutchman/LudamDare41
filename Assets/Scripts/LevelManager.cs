﻿using UnityEngine;
using System.Collections;

public class LevelManager2 : MonoBehaviour {

	public void LoadLevel(string name){
		Debug.Log ("New Level Load: " + name);
		Application.LoadLevel (name);
	}
	
	public void QuitRequest(){
		Debug.Log ("Quit Requested");
		Application.Quit ();
	}
	
	public void LoadNextLevel(){
		Application.LoadLevel (Application.loadedLevel + 1);
	}
	// Update is called once per frame
	void Update () {
		
	}
}

