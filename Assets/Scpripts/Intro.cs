using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class CambiadorDeEscena : MonoBehaviour
{
    public string nombreDeLaEscenaACargar;

    public void CambiarEscena()
    {
        SceneManager.LoadScene(nombreDeLaEscenaACargar);
    }

    public void QuitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        EditorApplication.isPaused = !EditorApplication.isPaused;
#endif

    }
}