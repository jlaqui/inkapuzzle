using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TumiCollision : MonoBehaviour
{
    public GameObject obj;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Player"))
        {
            obj.SetActive(true);
            Time.timeScale = 0f;
        }
    }

}
