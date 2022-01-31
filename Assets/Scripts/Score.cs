using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    AudioSource audio;
    
    private void OnTriggerEnter2D()
    {
        GameManager.Instance.IncreaseScore();
        audio.Play();
        
    }

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    
}
