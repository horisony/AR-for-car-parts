using UnityEngine;
using System.Collections;

public class showStep2b : MonoBehaviour {

	public GameObject ScrewDriver_b;
	public GameObject SparkPlugs_b;
	public GameObject Hand_b;
	public GameObject Step1_b;
	public GameObject Step2_b;
	public GameObject Step3_b;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		Step2_b.SetActive (false);
		Step3_b.SetActive (true);
		ScrewDriver_b.SetActive (false);
		SparkPlugs_b.SetActive (true);
		Debug.Log ("to next step");
	}
}
