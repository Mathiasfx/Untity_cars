using UnityEngine.SceneManagement;
using UnityEngine;

public class COMPLETE : MonoBehaviour {

    //public AdConfiguracion adConfiguracion;

	public void CargarSiguienteNivel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       // adConfiguracion.MostrarBanner();
        
    }
}
