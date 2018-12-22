
using UnityEngine;

public class SeguirCoche : MonoBehaviour {

    public Transform Coche;
    public Vector3 ofset;
    public Vector3 rotacion;


    private void Start()
    {
        transform.Rotate(rotacion);
       
    }

    // Update is called once per frame
    void Update () {

        transform.position = Coche.position + ofset;
     
		
	}
}
