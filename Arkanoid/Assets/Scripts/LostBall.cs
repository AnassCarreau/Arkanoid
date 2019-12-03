using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostBall : MonoBehaviour
{
    public Transform SpawnPoint;
    Rigidbody2D rb;
    GameManager mn;
    GameObject padre;
    // Start is called before the first frame update
    void Start()
    {
        padre = SpawnPoint.parent.gameObject;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
  public  void Onlost() 
    {
       if(mn.LoseLife()) 
        {
            Destroy(this.gameObject);
        }
        rb.isKinematic = true;
        transform.SetParent(padre.transform);
        transform.position = SpawnPoint.position;
    }
}
