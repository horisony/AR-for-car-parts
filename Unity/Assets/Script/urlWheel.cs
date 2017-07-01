using UnityEngine;
using System.Collections;

public class urlWheel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("start");
	}

	public void openURL(){
		Application.OpenURL("http://www.ebay.com/itm/Genuine-Ferrari-FXX-K-Wheel-kit-for-LaFerrari-70003876-Pirelli-Trofeo-R-/152512108472?hash=item23826e17b8:g:ZywAAOSwVm5Y8l5u&vxp=mtr");
	}

	void Update(){
	
	}
}
