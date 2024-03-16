using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LifeLost : MonoBehaviour
{
    public GameObject[] _healthSprites;

    public TMP_Text _aboutStateOfCollectableObject;
    private int currentScore;
    private void Start()
    {
        currentScore= PlayerPrefs.GetInt("CollectiblesLength");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        int _healthLevelLength = _healthSprites.Length;
        // De�di�imiz Nesneye tag ekleyelim
        if (collision.CompareTag("De�dimiz Engel Nesnesi ise"))
        {
            if (_healthLevelLength>0)
            {
                Destroy(_healthSprites[_healthLevelLength - 1]);

            }
            
        }
        if (collision.CompareTag("Buraya Collectible Prefab�n �smi Gelecek"))
        {
          
            int modifiedScore = currentScore;
            modifiedScore--;
            PlayerPrefs.SetInt("CollectiblesLength", modifiedScore);
            PlayerPrefs.Save();
            if (modifiedScore > 0)
            {
                _aboutStateOfCollectableObject.text = $"{modifiedScore}/{currentScore}";
                Destroy(collision.gameObject);

            }
            else
            {
                _aboutStateOfCollectableObject.text = $"{0}/{currentScore}";
            }


        }

    }
}
