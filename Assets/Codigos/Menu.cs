using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {


   

    public void StartGame()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

     

    }

    public void Youtube()
    {
        Application.OpenURL("https://www.youtube.com/channel/UC1BMrWdZwz-qR3CH_wKXVBQ");
    }

   

    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Pressed primary button.");
    }
}

