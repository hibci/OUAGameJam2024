using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ChildBehaviour : MonoBehaviour
{
    [SerializeField] private float _rightVelocity = 100f;
     private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame){
            
    }
    transform.position += Vector3.right * _rightVelocity * Time.deltaTime;
    }
}
