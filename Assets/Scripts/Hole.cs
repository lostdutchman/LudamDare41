﻿using UnityEngine;
using System.Collections;

public class Hole : MonoBehaviour {
	
	void OnTriggerEnter(Collider InHole)
	{
		if (InHole.tag == "Ball") 
		{
			Application.LoadLevel("Win");
		}
	}
}
