using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInitialSpeed : MonoBehaviour
{
    public Vector2 speed;

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = speed;
    }
}
