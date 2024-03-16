using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngelSpawner : MonoBehaviour
{
    [SerializeField] private float _maxTime = 1.5f;
    [SerializeField] private float _height = 0.45f;
    [SerializeField] private GameObject _engel;
    private float _timer;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEngel();
    }

    // Update is called once per frame
    void Update()
    {
        if(_timer > _maxTime){
            SpawnEngel();
            _timer = 0;
        }
        _timer += Time.deltaTime;
    }
    private void SpawnEngel()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-_height, _height));
        GameObject engel = Instantiate(_engel, spawnPos, Quaternion.identity);
        Destroy(engel, 10f);

    }
}
