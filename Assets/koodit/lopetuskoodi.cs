using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lopetuskoodi : MonoBehaviour
{

    void Update()
    {
       // Lopetus Esc-n�pp�imell�  
       if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit(); 
        } // if
    } // Update
} // class
