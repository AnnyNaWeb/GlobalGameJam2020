using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trocaTela : MonoBehaviour
{
    public GameObject mapScene;
    public GameObject mainScene;
  //  public GameObject falasCanvas;
    // Start is called before the first frame update
    public void TrocaTela()
    {
        mapScene.SetActive(false);
       // falasCanvas.SetActive(true);

    }
    public void TrocaTelaAgain()
    {
        mapScene.SetActive(true);
      //  falasCanvas.SetActive(false);

    }
    public void OnPrincipal()
    {
        mainScene.SetActive(true);
      //  falasCanvas.SetActive(true);
    }
    public void OffPrincipal()
    {
        mainScene.SetActive(false);
      //  falasCanvas.SetActive(false);
    }


}
