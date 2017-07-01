using UnityEngine;
using System.Collections;

public class clickToDetailSpark : MonoBehaviour {

	public GameObject Home;
	public GameObject DetailSpark;
//	public GameObject DetailBelt;
//	public GameObject DetailWheel;
//	public GameObject DetailBrake;

	// Use this for initialization
	void Start () {
		Home.SetActive (true);
		DetailSpark.SetActive (false);
//		DetailBelt.SetActive (false);
//		DetailWheel.SetActive (false);
//		DetailBrake.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown (){
		Home.SetActive (false);
		DetailSpark.SetActive (true);
		Debug.Log ("clicked");
	}
}
