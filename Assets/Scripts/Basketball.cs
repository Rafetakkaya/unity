using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Basketball : MonoBehaviour
{
    public int speed = 1000;
    AudioSource source;
    public AudioClip patlama;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject basket = transform.GetChild(1).gameObject;
            basket.transform.parent = null;
            basket.GetComponent<Rigidbody>().useGravity = true;
            basket.GetComponent<Rigidbody>().isKinematic = false;
            basket.GetComponent<Rigidbody>().AddForce(transform.GetChild(0).transform.forward * speed);
            Invoke(nameof(NewBall), 0.5f);
            source.PlayOneShot(patlama,4.7f);


        }
    }
    void NewBall()
    {
        GetComponent<TopOlusturma>().CreateBall();
    }
}
