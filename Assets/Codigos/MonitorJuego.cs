
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;



public class MonitorJuego : MonoBehaviour {

    //No anda asi si cuelga

    
    
    bool juegotermino = false;
    public float restartDelay = 0.4f;
    public GameObject completeLevelUI;


   
    public void GameOver()
    {
        

        if (juegotermino == false)
        {
            juegotermino = true;

            FindObjectOfType<ConADMOB>().MostrarInteristial();
     
            Invoke("Restart",restartDelay);
        }
    }

    void Restart()
    {
        
        SceneManager.LoadScene(1);

    }

    public void CompleteLevel()
    {
       
        completeLevelUI.SetActive(true);
        Invoke("Restart", restartDelay);
       
    }
}


