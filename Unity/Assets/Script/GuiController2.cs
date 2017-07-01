using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GuiController2 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnHome2(){
		SceneManager.LoadScene (0, LoadSceneMode.Single);
//		DetailSpark.SetActive (false);
//		HomePage.SetActive (true);
		Debug.Log("To Home Page");
	}
}
