using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaMenu : MonoBehaviour
{
    static bool first;
    void Start()
    {
        if(first)Destroy(gameObject);
        else{
            DontDestroyOnLoad(gameObject);
            first=true;
        }
    }

}
