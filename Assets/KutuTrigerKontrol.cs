using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KutuTrigerKontrol : MonoBehaviour
{
    // GetAxis 12.video 10. ders
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter(Collider go)
    {
        Debug.Log("iceride kutu var" + go.name);
        
    }
}
