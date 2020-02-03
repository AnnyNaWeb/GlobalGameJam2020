using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mymenu : MonoBehaviour
{
   // public Texture2D cursor;
    public Texture2D defaultTexture;
  //  public Texture2D ouvirTexture;
   // public Texture2D sairTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    void Start(){
        Cursor.SetCursor(defaultTexture, Vector2.zero,CursorMode.Auto);
    }
    
    public void cenajogo(){
       SceneManager.LoadScene("Cabaret");
   }
   public void cenaopcoes(){
       SceneManager.LoadScene("Opções");
   }
   public void cenacredito(){
       SceneManager.LoadScene("Créditos");
   }
   public void cenasair(){
       Application.Quit();

   }
   
}
