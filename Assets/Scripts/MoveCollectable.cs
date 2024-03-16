using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCollectable : MonoBehaviour
{
     [SerializeField] private float _speedCollectible = 0.65f;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * _speedCollectible * Time.deltaTime;
    }
}
