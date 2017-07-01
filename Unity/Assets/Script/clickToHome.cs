using UnityEngine;
using System.Collections;

public class clickToHome : MonoBehaviour {

	public GameObject Detail;
	public GameObject Home;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown (){
		Detail.SetActive (false);
		Home.SetActive (true);
	}
}
