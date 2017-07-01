using UnityEngine;
using System.Collections;

public class showStep1b : MonoBehaviour {

	public GameObject ScrewDriver_b;
	public GameObject SparkPlugs_b;
	public GameObject Hand_b;
	public GameObject Step1_b;
	public GameObject Step2_b;
	public GameObject Step3_b;

	// Use this for initialization
	void Start () {
		Step1_b.SetActive (true);
		Step2_b.SetActive (false);
		Step3_b.SetActive (false);
		Hand_b.SetActive (true);
		ScrewDriver_b.SetActive (false);
		SparkPlugs_b.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		Step1_b.SetActive (false);
		Step2_b.SetActive (true);
		Hand_b.SetActive (false);
		ScrewDriver_b.SetActive (true);
		SparkPlugs_b.SetActive (false);
		Debug.Log ("to next step");
	}
}
