using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //Declaramos variables publicas primero
    public float speed;
    Rigidbody2D rb;
    PlayerController pc;
    
    void Start()
    {
        pc = transform.parent.GetComponent<PlayerController>(); 
        rb = GetComponent<Rigidbody2D>();

      //Podemos usar rb.isKinematic como booleano de control porque solo cuando el cuerpo es cinematico está pegado al jugador
      //Esto es codigo protector para asegurarnos de que solo haya una bola, hija de la pala y creada como cinematica
        if (!rb.isKinematic || pc == null)
            Destroy(this.gameObject);      
    }

    void Update()
    {
      //Podemos usar rb.isKinematic como booleano de control porque solo cuando el cuerpo es cinematico está pegado al jugador
        if (Input.GetKeyDown(KeyCode.Return) && rb.isKinematic)
        {
            //Hacemos que la bola no sea dinamica e hija de nadie
            transform.parent = null;
            rb.isKinematic = false;
            //Y le asignamos una velocidad constante de angulo aleatorio entre 45 y 135 grados
            rb.velocity = new Vector2(Random.Range(-1f,1f), 1f).normalized*speed;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Solo si choca con la pala rebotará de esta forma, si no, su material fisico bounce le servirá
        pc = collision.gameObject.GetComponent<PlayerController>();
        if (pc != null)
            //Este calculo hace que si la bola rebota en el filo de la pala las componentes x e y de su velocidad seran iguales
            //Eso significa que en el centro rebota vertical y en el filo rebota a 45 grados
            rb.velocity = new Vector2(rb.position.x - pc.gameObject.transform.position.x, pc.gameObject.transform.localScale.x / 2).normalized*speed;
    }
}
