using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GuiController : MonoBehaviour {
	public GameObject HomePage;
	public GameObject DetailSpark;
	public GameObject DetailBrake;
	public GameObject DetailBelt;
	public GameObject DetailWheel;

	// Use this for initialization
	void Start () {
		DetailSpark.SetActive (false);
		DetailBrake.SetActive (false);
		DetailBelt.SetActive (false);
		DetailWheel.SetActive (false);
		HomePage.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnDetailSpark(){
		DetailSpark.SetActive (true);
		HomePage.SetActive (false);
	}

	public void OnDetailBelt(){
		DetailBelt.SetActive (true);
		HomePage.SetActive (false);
	}

	public void OnDetailBrake(){
		DetailBrake.SetActive (true);
		HomePage.SetActive (false);
	}

	public void OnDetailWheel(){
		DetailWheel.SetActive (true);
		HomePage.SetActive (false);
	}

	public void OnAll(){
		SceneManager.LoadScene ("all", LoadSceneMode.Single);

	}

	public void OnHome(){
		SceneManager.LoadScene (0, LoadSceneMode.Single);
		DetailSpark.SetActive (false);
		DetailBrake.SetActive (false);
		DetailBelt.SetActive (false);
		DetailWheel.SetActive (false);
		HomePage.SetActive (true);
	}

	public void OnUrlSpark(){
		Application.OpenURL ("http://m.ebay.com/sch/i.html?_nkw=ferrari+308+spark+plugs&isNewKw=1&isRefine=true&mfs=GOCLK&acimp=0&_trksid=p2056088.m2428.l1313.TR0.TRC0.Xferrari+308+spark+plugs&sqp=ferrari+308+spark+plugs");
	}

	public void OnUrlTyre(){
		Application.OpenURL ("http://m.ebay.com/sch/i.html?_nkw=ferrari+308+tyre&isNewKw=1&isRefine=true&mfs=GOCLK&acimp=0&_trksid=p2056088.m2428.l1313.TR0.TRC0.Xferrari+308+tyre&sqp=ferrari+308+tyre");
	}

	public void OnUrlBrake(){
		Application.OpenURL ("http://m.ebay.com/sch/i.html?_from=R40&_trksid=m4084.l1313&_nkw=ferrari+308+brake");
	}

	public void OnUrlBelt(){
		Application.OpenURL ("http://m.ebay.com/sch/i.html?_from=R40&_trksid=m4084.l1313&_nkw=ferrari+308+belt");
	}

	public void OnArSpark(){
		SceneManager.LoadScene ("sparkPlugs", LoadSceneMode.Single);
	}


}
