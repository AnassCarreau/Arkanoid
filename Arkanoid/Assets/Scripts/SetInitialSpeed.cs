using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInitialSpeed : MonoBehaviour
{
    public Vector2 InitialVelocity;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = InitialVelocity;
        
    }

}
