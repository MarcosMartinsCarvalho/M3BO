using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class playsound : MonoBehaviour
{
    AudioSource source;

    public int timer = 0;
    public bool kusjeaanhetgeven = false;

    Collider soundTrigger;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
        soundTrigger = GetComponent<Collider>();
    }

    private void Update()
    {
        if (kusjeaanhetgeven == true)
        {
            timer++;
        }
        if (kusjeaanhetgeven == false)
        {
            timer = 0;
            
        }
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            kusjeaanhetgeven = true;
            source.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            timer = 0;
            kusjeaanhetgeven = false;
            source.Stop();
        }
    }
}
