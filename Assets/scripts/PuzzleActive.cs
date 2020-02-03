using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleActive : MonoBehaviour
{
    public GameObject noticia;
    public GameObject puzzle;
    public GameObject mainScene;
    // Start is called before the first frame update
    
    public void onNoticia()
    {
        noticia.SetActive(true);
        mainScene.SetActive(false);
       // puzzle.SetActive(false);
    }
   
    public void Puzzle()
    {
        if (PuzzleControll.ganha)
        {
            onNoticia();
        }
        else
        {
            offPrincipal();
        }
          
    }

    public void onPrincipal()
    {
        mainScene.SetActive(true);
        noticia.SetActive(false);
    }
    public void offPrincipal()
    {
      
        puzzle.SetActive(true);
        mainScene.SetActive(false);
    }
 
}
