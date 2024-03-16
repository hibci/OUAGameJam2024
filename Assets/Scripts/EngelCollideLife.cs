using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EngelCollideLife : MonoBehaviour
{
    private Scene _scene;
    private void Awake()
    {
        _scene = SceneManager.GetActiveScene();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")){
            SceneManager.LoadScene(_scene.name);
        }

    }
    private void OnCollisionEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")){
            SceneManager.LoadScene(_scene.name);
        }
    }
}
