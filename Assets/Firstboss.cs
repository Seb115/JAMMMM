using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firstboss : MonoBehaviour
{
    public float speed = 1.0f;

    public FirstBossAggro aggroRange;

    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (aggroRange.Aggro == true)
        {
            var step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, step);
        }

        transform.position = new Vector3(transform.position.x, 8.5f, transform.position.z);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            var step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, other.transform.position, step);
        }
    }
}
