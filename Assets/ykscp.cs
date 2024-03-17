using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ykscp : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("child"))
        {
            Destroy(collision.gameObject); 
        }
    }

}
