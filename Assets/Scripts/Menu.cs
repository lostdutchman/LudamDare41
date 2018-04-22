using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public GameObject MenuScreen;

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			try
			{
				ToggleMenu();
			}
			catch
			{
				//Do nothing, this it to keep from getting an error on scenes that done have a menu
			}
		}
	}
	
	public void ToggleMenu()
	{
		if (MenuScreen.activeSelf)
		{
			MenuScreen.SetActive(false);
			Time.timeScale = 1;
		}
		else
		{
			Time.timeScale = 0;
			MenuScreen.SetActive(true);
		}
	}
}
