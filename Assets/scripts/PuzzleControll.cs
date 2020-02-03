using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleControll : MonoBehaviour
{
    public Text contador;
    public float tempo = 30.0f;
    [SerializeField]
    private Transform[] images;

    [SerializeField]
    private GameObject venceu;
    public GameObject puzzle;
    public GameObject mainScene;
    public GameObject noticia;

    public static bool ganha;
    public static bool perdeu;

    // Start is called before the first frame update
    void Start()
    {
      
        ganha = false;
        perdeu = false;
    }

    // Update is called once per frame
    void Update()
    {



        if (ganha)
        {

            noticia.SetActive(true);
            puzzle.SetActive(false);

        }
        
            temporizador();
        verificaVitoria();
        
       

    }
    void temporizador()
    {
        if (tempo > 0.0f)
        {
            tempo -= Time.deltaTime;
            contador.text = ((int)tempo).ToString();
            //contador.text = tempo.ToString("VOCE CONSEGUIU")
        }
        else
        { 
           // contador.text = "Tente novamente...";
          //  yield return new WaitForSeconds(3);
            perdeu = true;
           // mainScene.SetActive(true);
          //  puzzle.SetActive(false);
            StartCoroutine("esperar");
            

        }
        
    }
    IEnumerator esperar()
    {
        contador.text = "Tente novamente...";
        yield return new WaitForSeconds(3);
        //  perdeu = true;
        mainScene.SetActive(true);
        tempo = 15.0f;
       
          
       
        puzzle.SetActive(false);

    }
    
    void verificaVitoria()
    {
        if (images[0].rotation.z == 0 &&
          images[1].rotation.z == 0 &&
          images[2].rotation.z == 0 &&
          images[3].rotation.z == 0 &&
          images[4].rotation.z == 0 &&
          images[5].rotation.z == 0 &&
          images[6].rotation.z == 0 &&
          images[7].rotation.z == 0 &&
          images[8].rotation.z == 0 &&
          images[9].rotation.z == 0 &&
          images[10].rotation.z == 0 &&
          images[11].rotation.z == 0 &&
          images[12].rotation.z == 0 &&
          images[13].rotation.z == 0
         )
        {
            ganha = true;
            
        }

    }
}

