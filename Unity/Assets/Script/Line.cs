using UnityEngine;
using System.Collections;
using System.Threading;

public class Line : MonoBehaviour {

	private LineRenderer lineRenderer;
	private float counter;
	private float dist;

	public Transform origin;
	public Transform destination;

	void Start(){

		lineRenderer = GetComponent<LineRenderer> ();
		lineRenderer.SetPosition (0, origin.position);
		lineRenderer.SetWidth (.45f, .45f);

	}        

	void Update() {

		Vector3 pointB = destination.position;
		lineRenderer.SetPosition (1, pointB);
	

	}

}