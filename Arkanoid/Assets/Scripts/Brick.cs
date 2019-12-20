using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{ //LLama al añadir ladrillo del GameManager
    void Start()
    {
        GameManager.instance.AddBrick();
    }
    //LLama al destruir ladrillo del GameManager
    private void OnDestroy()
    {
        if(GameManager.instance!=null)
        GameManager.instance.BrickDestroyed();
    }
}
