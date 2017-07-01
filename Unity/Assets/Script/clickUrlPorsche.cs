using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class clickUrlPorsche : MonoBehaviour {

	void Start () {
		Debug.Log ("start");
	}

	void OnMouseDown() {
		Debug.Log ("clicked");
		Application.OpenURL("http://m.ebay.com/sch/i.html?_nkw=spark+plugs+porsche+cayenne&isNewKw=1&isRefine=true&mfs=GOCLK&acimp=0&_trksid=p2056088.m2428.l1313.TR0.TRC0.Xspark+plugs+porsche+cayenne&sqp=spark+plugs+porsche+cayenne");
	}
}