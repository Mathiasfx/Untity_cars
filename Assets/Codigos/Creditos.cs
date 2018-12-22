using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Creditos : MonoBehaviour {

    

public void Quit()
    {
        Debug.Log("Salir");
        Application.Quit();
        
    }

    public void Canal()
    {
        Application.OpenURL("https://www.youtube.com/channel/UC1BMrWdZwz-qR3CH_wKXVBQ");
        
       
    }


}
