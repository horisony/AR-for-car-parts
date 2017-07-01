using UnityEngine;
using System.Collections;

public class showStep1a : MonoBehaviour {

	public GameObject ScrewDriver;
	public GameObject SparkPlugs;
	public GameObject Hand;
	public GameObject Step1;
	public GameObject Step2;
	public GameObject Step3;

	// Use this for initialization
	void Start () {
		Step1.SetActive (true);
		Step2.SetActive (false);
		Step3.SetActive (false);
		Hand.SetActive (true);
		ScrewDriver.SetActive (false);
		SparkPlugs.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		Step1.SetActive (false);
		Step2.SetActive (true);
		Hand.SetActive (false);
		ScrewDriver.SetActive (true);
		SparkPlugs.SetActive (false);
		Debug.Log ("to next step");
	}
}
