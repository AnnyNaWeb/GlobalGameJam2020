using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verificaCollider : MonoBehaviour
{
    [SerializeField]
    private Transform image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PuzzleControll.perdeu)
        {
            image.GetComponent<Collider2D>().enabled = true;
            PuzzleControll.perdeu = false;
        }
        if (image.rotation.z == 0)
        {
            image.GetComponent<Collider2D>().enabled = false;
           
        }
    }
}
