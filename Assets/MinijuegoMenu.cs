using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MinijuegoMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Minijuego1()
    {
        SceneManager.LoadScene("Minijuego1_2");
    }

    public void Minijuego2()
    {
        SceneManager.LoadScene("Minijuego2_1");
    }

    public void Minijuego3()
    {
        SceneManager.LoadScene("Minijuego3_1");
    }

    public void Regresar()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
