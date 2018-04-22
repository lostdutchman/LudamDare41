using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.LoadLevel("OpeningAlt");
		}
	}
	

}
