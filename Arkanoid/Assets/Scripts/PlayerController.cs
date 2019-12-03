using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocityScale;

    //Este es el ancho de la pantalla visible con la razón de aspecto 16:10
    Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //Queremos que los límites de la pala sean lo que choquen con el borde, no su centro

    }


    void FixedUpdate()
    {

        //Movemos en una dirección según se pulsen las flechas derecha e izquierda
        if (Input.GetKey(KeyCode.RightArrow))
            rb.AddForce(new Vector2(velocityScale, 0));
        if (Input.GetKey(KeyCode.LeftArrow))
            rb.AddForce(new Vector2(-velocityScale, 0));

    }


}
