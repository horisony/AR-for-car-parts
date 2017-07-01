using UnityEngine;
using System.Collections;

public class faceCamera : MonoBehaviour {

	public Camera myCamera;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (transform.position + myCamera.transform.rotation*Vector3.forward, myCamera.transform.rotation*Vector3.up);
	}
}
