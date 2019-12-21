using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemRotate : MonoBehaviour
{
    public int rotateSpeed = 2;

    // Update is called once per frame
    void Update()
    {
        //  4th parameter will rotate relative to the world.
        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0, Space.World);

        
    }

    void OnCollisionEnter(Collision collision)
    {
        gameObject.SetActive(false);
    }

}
