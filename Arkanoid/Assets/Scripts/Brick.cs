using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
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
