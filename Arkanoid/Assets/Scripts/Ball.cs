using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Transform spawnpoint;
    Rigidbody2D rb;
    PlayerController pc;
    
    void Start()
    {
        pc = transform.parent.GetComponent<PlayerController>(); 
        rb = GetComponent<Rigidbody2D>();
        if (!rb.isKinematic || pc == null)
            Destroy(this.gameObject);
       
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && rb.isKinematic)
        {
            transform.parent = null;
            rb.isKinematic = false;
            rb.velocity = new Vector2(Random.Range(-1f,1f), 1f).normalized*speed;
        }

    }
}
