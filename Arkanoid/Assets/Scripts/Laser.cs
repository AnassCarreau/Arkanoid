using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public Sprite attackmode;
    //Guardamos el sprite original para volver a el cuando termine el script
    Sprite regular;
    public GameObject fire;
    void OnEnable()
    {
        regular = GetComponent<SpriteRenderer>().sprite;
        GetComponent<SpriteRenderer>().sprite = attackmode;
    }

    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate (fire, transform.position, Quaternion.identity);
    }

    private void OnDisable()
    {
        //Devolvemos el sprite original
        GetComponent<SpriteRenderer>().sprite = regular;
    }
}
