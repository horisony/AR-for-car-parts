using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class clickUrlFerrariWheel : MonoBehaviour {

	void Start () {
		Debug.Log ("start");
	}

	void OnMouseDown() {
		Debug.Log ("clicked");
		Application.OpenURL("http://m.ebay.com/sch/i.html?_nkw=ferrari+308+wheels&isNewKw=1&isRefine=true&mfs=GOCLK&acimp=0&_trksid=p2056088.m2428.l1313.TR6.TRC1.Xferrari+308+wheels&sqp=ferrari+308+wheels");
	}
}