using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NivelController : MonoBehaviour
{
    public void ContinuarNivel2(string escena)
    {
        SceneManager.LoadScene(escena);
        Time.timeScale = 1f;
    }
    public void Salir()
    {
        SceneManager.LoadScene("MenuMinijuego");
        Time.timeScale = 1f;
    }
}
