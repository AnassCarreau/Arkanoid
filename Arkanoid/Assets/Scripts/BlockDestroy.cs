using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDestroy : MonoBehaviour
{
    public int lives;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        //GameManager.ScoreIncrease(3);
        lives--;
        if (lives<=0)
            Destroy(this.gameObject);
    }
}
