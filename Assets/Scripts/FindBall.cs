using UnityEngine;
using System.Collections;

public class FindBall : MonoBehaviour {

	private Time TimeSinceLastHit;
	private ParticleSystem Particals;

	void Start()
	{
		Particals = GetComponent<ParticleSystem>();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Tab)) {
			StartCoroutine(LightUp());
		} 
	}
	
	IEnumerator LightUp() {
		Particals.Emit(50);
		yield return new WaitForSeconds (.3f);
		Particals.Emit(50);
		yield return new WaitForSeconds (.3f);
		Particals.Emit(50);
		yield return new WaitForSeconds (.5f);
		Particals.Emit(50);
	}
}
