using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    float x;
    float y=1;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

         x = Random.Range(-10, 10);
        rb.isKinematic = true;
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && rb.isKinematic)
        {
            rb.isKinematic = false;
            rb.velocity= new Vector2(x, speed);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        float x= (transform.position.x - collision.transform.position.x) / collision.transform.localScale.x;
        if (collision.transform.position.y > 0) { y = -1;}
        if (collision.gameObject.CompareTag("Player")){ y = 1; }
        rb.velocity =new  Vector2(x,y).normalized * speed;
    }
   
}
