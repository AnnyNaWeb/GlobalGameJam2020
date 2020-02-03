using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cabaretTelas : MonoBehaviour
{
    public GameObject falasCanvas;
    // Start is called before the first frame update
  public  void mudaTela()
    {
        falasCanvas.SetActive(true);

    }

    // Update is called once per frame
  public  void mudaTelaAgain()
    {
        falasCanvas.SetActive(false);
    }
}
