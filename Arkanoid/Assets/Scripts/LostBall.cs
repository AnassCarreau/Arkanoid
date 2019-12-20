using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostBall : MonoBehaviour
{
    public Transform spawnpoint;
    GameObject plyr;
    //Ball se hace hija de la pala sabiendo que spawnpoint siempre es hija de la pala
    void Start()
    {
        plyr = spawnpoint.parent.gameObject;
    }
    //La velocidad de la bola se hace nula , su posicion pasa a ser la de spawnpoint , se hace hija de la pala y  con movimiento cinematico 
    //Si ya no quedan vidas de jugador se destruye la bola 
    public void OnLost()
    {
        if (GameManager.instance.PlayerLoseLife())
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();

            rb.velocity = Vector2.zero;
            transform.SetParent(plyr.transform);
            transform.position = spawnpoint.position;
            rb.isKinematic = true;
        }
        else
            Destroy(this.gameObject);        
    }
}
