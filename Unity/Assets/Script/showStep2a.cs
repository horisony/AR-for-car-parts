using UnityEngine;
using System.Collections;

public class showStep2a : MonoBehaviour {

	public GameObject ScrewDriver;
	public GameObject SparkPlugs;
	public GameObject Hand;
	public GameObject Step1;
	public GameObject Step2;
	public GameObject Step3;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		Step2.SetActive (false);
		Step3.SetActive (true);
		ScrewDriver.SetActive (false);
		SparkPlugs.SetActive (true);
		Debug.Log ("to next step");
	}
}
