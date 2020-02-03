using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoomCamera : MonoBehaviour { 

    public float tamZoom = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        { 
           if(tamZoom > 2)
            {
                tamZoom -= 1;
            }

        }
        if(Input.GetAxis("Mouse ScrollWheel") < 0)
    {
            if (tamZoom < 4)
            {
                tamZoom += 1;
            }
            
    }
        GetComponent<Camera>().orthographicSize = tamZoom;
    }
}
