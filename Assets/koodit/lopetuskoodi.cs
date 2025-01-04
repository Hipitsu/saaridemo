using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lopetuskoodi : MonoBehaviour
{

    void Update()
    {
       // Lopetus Esc-näppäimellä  
       if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit(); 
        } // if
    } // Update
} // class
