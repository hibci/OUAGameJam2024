using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCollide : MonoBehaviour
{
    private Animator _anim;
    private Rigidbody2D rb2d;
    
    [SerializeField] private GameObject _collectible;
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

   
    void OnCollisionEnter2D(GameObject other)
    {
        if (other.gameObject.CompareTag("Player")){
            _anim.SetBool("collide", true);
            Destroy(_collectible, 1f);
            Debug.Log("collision");
        
        }
    }
}
