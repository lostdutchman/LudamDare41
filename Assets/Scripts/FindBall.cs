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
			Particals.enableEmission = true;
		} else {
			Particals.enableEmission = false;
		}
	}
}
