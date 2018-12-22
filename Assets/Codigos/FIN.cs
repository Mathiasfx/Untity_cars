using UnityEngine;

public class FIN : MonoBehaviour {

    public MonitorJuego monitorJuego;

    void OnTriggerEnter()
    {
        monitorJuego.CompleteLevel();
    }

}
