using UnityEngine.Audio;
using UnityEngine;


public class Colision : MonoBehaviour {

    public MovimientoCoche movimiento;
   
   
    


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "obstaculo")
        {
            movimiento.enabled = false;

            
            FindObjectOfType<MonitorJuego>().GameOver();

            


        }
    }



}
