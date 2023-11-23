using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetected : MonoBehaviour
{
    public GameObject patlama;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnCollisionEnter(Collision obj)
    {
        Debug.Log("carpisti");
        Destroy(this.gameObject);
        Destroy(obj.gameObject);
        Instantiate(patlama, this.gameObject.transform.position, this.gameObject.transform.rotation);
        
    }
}
