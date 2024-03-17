using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toplama : MonoBehaviour
{
    private int count;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("collectible"))
        {
            count++;
            Destroy(collision.gameObject);
            AudioManager.Instance._source.clip = AudioManager.Instance._audioClips[0];
            AudioManager.Instance._source.Play();
        }
    }
}
