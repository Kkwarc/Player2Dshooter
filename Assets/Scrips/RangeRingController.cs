using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeRingController : MonoBehaviour
{
    public float lifeTime = 0.1f;

    private Rigidbody2D rb;

    private Player player;
    private Transform playerPos;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        rb.transform.localScale = new Vector3(player.range, player.range, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        rb.transform.position = player.transform.position;
        //rb.position = playerPos.position;
        if (lifeTime <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            lifeTime -= Time.deltaTime;
        }
    }
}
