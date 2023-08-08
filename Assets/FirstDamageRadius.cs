using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstDamageRadius : MonoBehaviour
{
    public bool damaged;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            damaged = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            damaged = false;
        }
    }
}
