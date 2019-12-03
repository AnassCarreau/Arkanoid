using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager.AddBrick();
    }
    private void OnDestroy()
    {
        gameManager.BrickDestroyed();
    }
}
