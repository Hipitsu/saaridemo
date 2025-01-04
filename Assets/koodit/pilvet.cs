using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pilvet : MonoBehaviour
{
    void Update()
    {
        // Pyöritetään SkyBoxia
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * 0.3f);
    } // Update
} // class
