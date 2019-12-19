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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerController pc = collision.gameObject.GetComponent<PlayerController>();
        if (pc != null)
            rb.velocity = new Vector2(rb.position.x - pc.gameObject.transform.position.x, pc.gameObject.transform.localScale.x / 2).normalized*speed;
    }
}
