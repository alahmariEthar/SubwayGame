using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip coinCollect;
    void Start()
    {
       audioSource= GetComponent<AudioSource>() ;
    }

  public void PlayCoinCollect(){
    audioSource.PlayOneShot(coinCollect);
  }

}
