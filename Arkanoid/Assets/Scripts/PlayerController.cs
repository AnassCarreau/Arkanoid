using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    //Queremos que la velocidad de desplazamiento de la pala sea configurable desde el editor
    public float VelocityScale;

    //Este es el ancho de la pantalla visible con la razón de aspecto 16:10
    float anchoMundo = 10.5f;


    private void Start()
    {
        //Queremos que los límites de la pala sean los que choquen con los bordes, no su centro
        anchoMundo -= transform.localScale.x;
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * VelocityScale, 0f);
    }
}

