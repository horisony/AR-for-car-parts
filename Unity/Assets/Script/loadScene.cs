using UnityEngine;
using System.Collections;

public class loadScene : MonoBehaviour {

	void Start () {
		Debug.Log ("start");
	}

	public void ChangeScene(string sceneName){
		Application.LoadLevel (sceneName);
		Debug.Log ("Load Scene Sphere");
	}
}
