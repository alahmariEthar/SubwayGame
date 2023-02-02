using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinCoins : MonoBehaviour
{
   
  
   void Update()
    {  transform.Rotate(100*Time.deltaTime,0f, 0f, Space.Self);    }


}
