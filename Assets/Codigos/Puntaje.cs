using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour {

    public Transform Player;
    public Text PuntajeText;
    public string temp;

    private void Start()
    {
        temp = "";
    }


    // Update is called once per frame
    void Update () {
        PuntajeText.text = Player.position.z.ToString("0");

        if(PuntajeText.text == temp)
        {
            PuntajeText.text = "0";
            FindObjectOfType<MonitorJuego>().GameOver();
        }


	}

    }
