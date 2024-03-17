using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public List<AudioClip> _audioClips;
    public AudioSource _source;
    private static AudioManager _instance;
    public static AudioManager Instance
    {
        get {
            if (_instance == null)
            {
                _instance=FindObjectOfType<AudioManager>();
                if(_instance == null )
                {
                    _instance=new GameObject("GameManager").AddComponent<AudioManager>();
                }
            }
            return _instance;
        }
    }

    private void Awake()
    {
         if(_instance == null )
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
