using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LocalManager : MonoBehaviour
{
    public void Cabaret()
    {
        SceneManager.LoadScene(3);
    }
    public void Jornal()
    {
        SceneManager.LoadScene(4);
    }
    public void Porto()
    {
        SceneManager.LoadScene(5);
    }
    public void Cortico()
    {
        SceneManager.LoadScene(6);
    }
}
