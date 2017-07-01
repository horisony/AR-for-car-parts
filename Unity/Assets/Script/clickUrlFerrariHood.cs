using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class clickUrlFerrariHood : MonoBehaviour {

	void Start () {
		Debug.Log ("start");
	}

	void OnMouseDown() {
		Debug.Log ("clicked");
		Application.OpenURL("http://m.ebay.com/sch/i.html?_from=R40&_trksid=m4084.l1313&_nkw=ferrari+308+hoods");
	}
}