using UnityEngine;
using System.Collections;

public class YouWin : MonoBehaviour {

	public GameObject M1, M2, M3, M4, M5, Victory;
	public float Pause = .5f;

	void Start(){
		Merit();
	}

	IEnumerator Merit() {
		M1.SetActive (true);
		yield return new WaitForSeconds (Pause);
		M2.SetActive (true);
		yield return new WaitForSeconds (Pause);
		M3.SetActive (true);
		yield return new WaitForSeconds (Pause);
		M4.SetActive (true);
		yield return new WaitForSeconds (Pause);
		M5.SetActive (true);
		yield return new WaitForSeconds (Pause * 2);
		Victory.SetActive (true);
	}
}
