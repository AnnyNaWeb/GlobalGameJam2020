using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseControll_Puzzle : MonoBehaviour
{
    // Start is called before the first frame update


    private void OnMouseDown()
    { 
        

       
            if (Input.GetMouseButtonDown(0))
            {


                transform.Rotate(0f, 0f, 90f);




            }

         
            //    GameObject.transform.Rotate(0f, 0f, 90f);

            

        
    }

    
}
