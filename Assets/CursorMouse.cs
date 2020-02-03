using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorMouse : MonoBehaviour
{
    public Texture2D defaultTexture;
    public Texture2D ouvirTexture;
    public Texture2D sairTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    void Start()
    {
        Cursor.SetCursor(defaultTexture, hotSpot, cursorMode);
    }
    public void OnMouseEnter()
    {
        if (gameObject.tag == "mesa")
        {
            Cursor.SetCursor(ouvirTexture, hotSpot, cursorMode);
        }
        if (gameObject.tag == "porta")
        {
            Cursor.SetCursor(sairTexture, hotSpot, cursorMode);
        }

    }
    
    void OnMouseExit()
    {
        Cursor.SetCursor(defaultTexture, hotSpot, cursorMode);
    }
}
