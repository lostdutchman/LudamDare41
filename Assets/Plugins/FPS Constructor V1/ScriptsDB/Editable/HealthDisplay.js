/*
 FPS Constructor - Weapons
 Copyright© Dastardly Banana Productions 2011-2012
 This script, and all others contained within the Dastardly Banana Weapons Package are licensed under the terms of the
 Unity Asset Store End User License Agreement at http://download.unity3d.com/assetstore/customer-eula.pdf 
 
  For additional information contact us info@dastardlybanana.com.
*/

var playerHealth : PlayerHealth;
static var ShotsFired;

function Start(){
	playerHealth = this.GetComponent(PlayerHealth);
	ShotsFired = 0;
}

static function Shot(){
	ShotsFired++;
}

function OnGUI(){
		GUI.Box(Rect(10,Screen.height-30,100,20),"Strokes: " + ShotsFired);
}
