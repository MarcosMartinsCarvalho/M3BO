using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class lightscript : MonoBehaviour
{

    private Light l;
    public KeyCode knopje;
    public bool flashlightOn = true;

    // Start is called before the first frame update
    void Start()
    {
        l = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
       

            if (flashlightOn && Input.GetKeyUp(knopje))
            {
                l.intensity = 0;
                flashlightOn = false;
            }

            else if (!flashlightOn && Input.GetKeyUp(knopje))
            {
                l.intensity = 6;
                flashlightOn = true;
            }

       



    }
}
