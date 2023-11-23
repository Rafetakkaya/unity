using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesKontrol : MonoBehaviour
{
    public AudioClip patlama;
    // Start is called before the first frame update
    AudioSource aSource;
    void Start()
    {
        aSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            aSource.Pause();

        }
        else if (Input.GetKeyUp(KeyCode.B))
        {
            aSource.Play();
        }

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    aSource.PlayOneShot(patlama,.7f);
        //}
        //else if (Input.GetKeyUp(KeyCode.B))
        //{
        //    aSource.Pause();
        //}



    }
}
