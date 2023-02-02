using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DisplayCoin : MonoBehaviour
{
   // private PlayerJump playerJumpScript;
   private int Coins=0;
   [SerializeField] private TextMeshProUGUI displaytheCoin;
  // [SerializeField] private string winScene;
  public SoundManager sm;

     void Start()
    {
    //   playerJumpScript=GetComponent<PlayerJump>(); 
    }
    private void Update() {
    
        displaytheCoin.text =(""+Coins); 
    }


  private void OnTriggerEnter(Collider other) {
    if(other.gameObject.CompareTag("Coin")){
      Coins+=1;
      Debug.Log("I win this much of coin!!"+Coins);
     sm.PlayCoinCollect();
     Destroy(other.gameObject);
    }
      
  }
}
