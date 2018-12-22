using UnityEngine;

public class SonidosChoque : MonoBehaviour {

    public AudioClip Clip;
    

  

  void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "obstaculo")
        {
            GetComponent<AudioSource>().PlayOneShot(Clip);
        }
    }

}

