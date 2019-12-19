using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public Sprite attackmode;
    public GameObject fire;
    void OnEnable()
    {
        GetComponent<SpriteRenderer>().sprite = attackmode;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate (fire, transform.position, Quaternion.identity);
    }
}
