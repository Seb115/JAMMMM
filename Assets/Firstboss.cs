using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class Firstboss : MonoBehaviour
{
    public float speed = 1.0f;
    public float lastAttack = 0.0f;
    public bool Charge, contactwithPlayer;

    public FirstBossAggro aggroRange;
    public FirstAttackRadius attackRadius;
    public ThirdPersonController player;
    public FirstDamageRadius Damagerad;

    public GameObject Player, Attackrad;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        Attackrad = GameObject.Find("FirstAttack");
        player = Player.GetComponent<ThirdPersonController>();

    }

    // Update is called once per frame
    void Update()
    {
        if (attackRadius.Attack == true && Time.time - lastAttack > 6.0f)
        {
            Charge = true;
            lastAttack = Time.time;
        }

        if (Charge && Time.time - lastAttack < 1.0f)
        {
            speed = 3.0f;
        }
        else if (Charge && Time.time - lastAttack < 2.5f)
        {
            speed = 10.0f;
        }
        else
        {
            speed = 1.0f;
        }


        if (aggroRange.Aggro == true && !contactwithPlayer)
        {
            var step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, step);
        }

        transform.position = new Vector3(transform.position.x, 6.0f, transform.position.z);

        if (Damagerad.damaged)
        {
            player.Hp -= 1.0f;
            Damagerad.damaged = false;
        }
    }
}
