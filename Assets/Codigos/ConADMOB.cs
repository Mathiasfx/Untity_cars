using UnityEngine;
using GoogleMobileAds.Api;

public class ConADMOB : MonoBehaviour {

	InterstitialAd interstitial;

	// Use this for initialization
	void Start () {
		RequestInteristial();
	}

	public void MostrarInterstitial(){
		
		Debug.Log("MUESTRA PUBLI!");
		
		if(interstitial.IsLoaded()){
			interstitial.Show();
			
		}
	}
	
	private void RequestInteristial(){

		#if UNITY_ANDROID
		string InterID ="ca-app-pub-9460971364470405/9870463503";
		#endif

		//Inicializar Interstitial
		interstitial = new InterstitialAd(InterID);

		//CuandoCierra
		interstitial.OnAdClosed += CierraInterstitial;

		//crear un request

		AdRequest request = new AdRequest.Builder().Build();
		interstitial.LoadAd(request);



	}

	public void CierraInterstitial(object sender,System.EventArgs e){
		RequestInteristial();
	}
}
