using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playsound : MonoBehaviour
{

    AudioSource source;

    public int timer = 0;
    public bool kusjeaanhetgeven = false ;

    Collider soundTrigger;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
        soundTrigger = GetComponent<Collider>();
    }

    private void Update()
    {
        if(kusjeaanhetgeven == true)
        {
            timer++;
        }
        
    }
    // Start is called before the first frame update
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
