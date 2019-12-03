using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    public int GolpesAntesDeMorir;
    public int PuntosGanados;
    public GameObject powerup;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            GolpesAntesDeMorir--;
            if (GolpesAntesDeMorir == 0) 
            {
                Instantiate(powerup);
                Destroy(this);
            }
        }
    }
}
