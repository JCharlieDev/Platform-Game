using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemRotate : MonoBehaviour
{
    private int rotateSpeed = 2;

    public int RotateSpeed 
    {
        get => rotateSpeed; 
        set => rotateSpeed = value; 
    }

    // Update is called once per frame
    void Update()
    {
        //  4th parameter will rotate relative to the world.
        transform.Rotate(0, RotateSpeed * Time.deltaTime, 0, Space.World);        
    }

}
