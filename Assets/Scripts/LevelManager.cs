using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevelAfter;

	// Use this for initialization
	void Start () {
		if (Application.loadedLevel == 0)
		{
			Invoke ("LoadNextLevel", autoLoadNextLevelAfter); 
		}
	}
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

	public void LoadRandomLevel(){
		if (Random.Range (0, 2) == 0) {
			Application.LoadLevel ("PHXOpen");
		} else {
			Application.LoadLevel ("KansasOpen");
		}
	}
}
