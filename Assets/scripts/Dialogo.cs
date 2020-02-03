using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Dialogo : MonoBehaviour
{
    public string letra;
    public string[] textos;
    public RawImage caixa;
    public Text fala;
    public static string usados="";
    int id;
    public void Mostrar()
    {
        if(usados.Contains(letra))return;
        caixa.gameObject.SetActive(true);
        usados+=letra;
        fala.text=textos[id];
        enabled=true;
    }

    void Update()
    {
        if(Input.GetMouseButtonUp(0)){
            id++;
            if(id>=textos.Length){
                enabled=false;
                caixa.gameObject.SetActive(false);
            }
            else fala.text=textos[id];
        }
    }
}
