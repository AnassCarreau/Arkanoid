using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enlarge : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale=new Vector3(transform.localScale.x * 1.25f,transform.localScale.y,transform.localScale.z); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
