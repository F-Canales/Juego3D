using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    float velocidadX = 2.0f;
    float velocidadY = 2.0f;
    float vX,vY;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        vX+= velocidadX * Input.GetAxis("Mouse Y");        
        vY+= velocidadY * Input.GetAxis("Mouse X");

        transform.eulerAngles= new Vector3(vX, vY, 0.0f);
    }
}

