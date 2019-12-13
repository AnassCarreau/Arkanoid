using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    public int GolpesAntesDeMorir;
    public int PuntosGanados;
  


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (GolpesAntesDeMorir > 1)
            GolpesAntesDeMorir--;
        else
        {
            GameManager.instance.AddPoints(PuntosGanados);
            Destroy(this.gameObject);
        }
        Debug.Log("collision");
    }
}
