using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstBossAggro : MonoBehaviour
{
    public bool Aggro;
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
            Aggro = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Aggro = false;
        }
    }
}
