using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
    
{
   public GameObject menuMap;
    // Start is called before the first frame update
    public void OnCanvasMap()
    {
        menuMap.SetActive(true);
    }
    public void OffCanvasMap()
    {
        menuMap.SetActive(false);
    }
}
