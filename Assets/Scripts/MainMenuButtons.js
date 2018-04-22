#pragma strict

public bool isStart;
public bool isQuit;

void onMouseUp(){
	if(isStart)
	{
		Application.LoadLevel(1);
	}
	if (isQuit);
	{
		Applicaton.Quit();
	}
}
