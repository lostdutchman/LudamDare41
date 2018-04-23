using UnityEngine;
using System.Collections;

public class Tutorial : MonoBehaviour {

	public GameObject Tut;

	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad > 1f) {
			Tut.SetActive(false);
		}
	}
}
