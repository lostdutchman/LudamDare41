using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuFade : MonoBehaviour {

	public Image Fade;
	public GameObject FadeObj;

	void Start () {
		Fade.CrossFadeAlpha (0f, 3.5f, false);
		StartCoroutine(FadeWait ());
	}

	IEnumerator FadeWait() {
		yield return new WaitForSeconds (3.5f);
		FadeObj.SetActive (false);
	}
}
