using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSky : MonoBehaviour
{
    public float rotationSpeed = 1.2f;

    // Update is called once per frame
    void Update()
    {
        //  I think it's better to intantiate empty objects with placeholders for stuff like this.
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotationSpeed);
    }
}
