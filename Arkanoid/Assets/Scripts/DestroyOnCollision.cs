using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    public int GolpesAntesDeMorir;
    public int PuntosGanados;
    public GameObject DieObject;
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (GolpesAntesDeMorir > 1)
            GolpesAntesDeMorir--;
        else
        {
            GameManager.instance.AddPoints(PuntosGanados);
            if (DieObject!=null)
                Instantiate(DieObject, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
        //Debug.Log("collision");
    }
}