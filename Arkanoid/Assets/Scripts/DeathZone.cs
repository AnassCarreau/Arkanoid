using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{

    LostBall ls;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ls = collision.GetComponent<LostBall>();
        if (ls != null) 
        {
            ls.Onlost();
        }
        else 
        {
            Destroy(collision);
        }
    }
}
