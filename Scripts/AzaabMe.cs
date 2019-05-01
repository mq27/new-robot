using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AzaabMe : MonoBehaviour
{
 
    private Animator hont;
   

    void Start()
    {
        hont = GetComponent<Animator>();
        GetComponent<AudioSource>();
    }

    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
        {
            if (null!=hont)
            hont.Play("hont");
        }

    }
}