using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject collectiblePrefab;
    public float spawnRadius = 5f;
    public int numberOfCollectibles = 10; // Toplanabilir Obje Say�s�
    private Vector2 _randomPositionViewByGizmoz;
    
     

    void Start()
    {
        PlayerPrefs.SetInt("CollectiblesLength", numberOfCollectibles);
        for (int i = 0; i < numberOfCollectibles; i++)
        {
            Vector2 randomPosition = Random.insideUnitCircle * spawnRadius;
            _randomPositionViewByGizmoz = randomPosition;
            Instantiate(collectiblePrefab, randomPosition, Quaternion.identity);
            
        }
    }

    // Burada Edit�rde Gizmo ile Ne Kadar Bir Alan ��inde Randomize i�lemi Yap�ld��� G�r�nt�lenir.

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(_randomPositionViewByGizmoz, 5f);
    }
}
