using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasketCheck : MonoBehaviour
{
    public bool ust = false, alt = false;
    

  

     void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ust")
        {

            
             ust = true;
         

        }
        if (other.tag == "Alt")
        {
            alt = true;
        }
        
    }
   
}
