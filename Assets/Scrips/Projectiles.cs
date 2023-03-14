using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    public float speed;

    private Vector2 target;
    private Transform initPos;

    private float range;

    public bool piercing = false;
    public int enemyKill = 0;


    // Start is called before the first frame update
    void Start()
    {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Player player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        initPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        range = player.range;
        if (player.gun == 2)
        {
            piercing=true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if ((Vector2.Distance(transform.position, initPos.position) > range) || (Vector2.Distance(transform.position, target) < 0.2f))
        {
            Destroy(gameObject);
        }
    }
}
