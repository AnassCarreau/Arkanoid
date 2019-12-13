using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    //Queremos que la velocidad de desplazamiento de la pala sea configurable desde el editor
    public float unitPerSecs;

    //Este es el ancho de la pantalla visible con la razón de aspecto 16:10
    float anchoMundo = 10.5f;


    private void Start()
    {
        //Queremos que los límites de la pala sean los que choquen con los bordes, no su centro
        anchoMundo -= transform.localScale.x;
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {

        //Movemos en una dirección según se pulsen las flechas derecha e izquierda
        if (Input.GetKey(KeyCode.RightArrow))
            rb.AddForce(new Vector2(unitPerSecs, 0));
        //Hacemos dos if en lugar de un if/else porque así no se mueve si se pulsan ambas flechas a la vez
        if (Input.GetKey(KeyCode.LeftArrow))
            rb.AddForce(new Vector2(-unitPerSecs, 0));
    }
}

