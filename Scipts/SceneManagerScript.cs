using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[SerializeField]
public class SceneManagerScript : MonoBehaviour
{
    
    

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void QuitApp()
    {
        Application.Quit();
    }
   
}
