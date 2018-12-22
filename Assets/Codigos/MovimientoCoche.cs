using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCoche : MonoBehaviour {

    public Rigidbody rb;
    public float Velocidad = 4000f;
    public float VelocidadVolante = 85f;
    public bool Derecha;
    public bool Izquierda;


 
 


	
	// Update is called once per frame fixed ayuda al calculo con Fisicas
	void FixedUpdate () {

        //Adiere la fuerza de la velocidad
        rb.AddForce(0, 0, Velocidad * Time.deltaTime);


        //CONTROL PC
        // if (Input.GetAxis("Horizontal")==-1)
        if (Derecha == true)
        {
         rb.AddForce(VelocidadVolante * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            Debug.Log("Izquierda");

        }

        //if (Input.GetAxis("Horizontal") == 1)
        if (Izquierda == true)
        {
        rb.AddForce(- VelocidadVolante * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            Debug.Log("Derecha");

        }



        if (rb.position.y < -1f)
        {
          FindObjectOfType<MonitorJuego>().GameOver();
        }

       
    }

    public void MoverDerecha()
    {

        Derecha = true;

    }

    public void MoverIzquierda()
    {

        //Debug.Log("Preciona");
        Izquierda = true;

    }

    public void Detener()
    {
        Izquierda = false;
        Derecha = false;
    }




}

