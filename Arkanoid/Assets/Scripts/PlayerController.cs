using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    //Queremos que la velocidad de desplazamiento de la pala sea configurable desde el editor
    public float VelocityScale;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        //Usamos rb.velocity para mover el objeto físico y GetAxis para cubrir con una instrucción los dos casos
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * VelocityScale, 0f);
    }
}