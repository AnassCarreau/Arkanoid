using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    void Start()
    {
        GameManager.instance.AddBrick();
    }
    private void OnDestroy()
    {
        GameManager.instance.BrickDestroyed();
    }
}
