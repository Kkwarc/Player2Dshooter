using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float health = 1;

    public GameObject effect;
    private Transform playerPos;
    private Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        speed = Mathf.Max(speed, (player.score + 10) / 10);
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);

        Quaternion target;
        if (playerPos.position.x > transform.position.x)
        {
            // Rotate the cube by converting the angles into a quaternion.
            target = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            target = Quaternion.Euler(0, 180, 0);
        }
        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 180);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            player.health--;
            Debug.Log(player.health);
            Destroy(gameObject);
        }
        if (other.CompareTag("Shoot"))
        {
            health -= player.damage; // tu jest b³¹d -> damage jest z obecnej chwili a nie danego pocisku
            Projectiles shot = other.GetComponent<Projectiles>();
            if (shot.piercing)
            {
                if (shot.enemyKill > 1)
                {
                    Destroy(other.gameObject);
                }
                else
                {
                    shot.enemyKill++;
                }
            }
            else {
                Destroy(other.gameObject);
            }
            
            if (health <= 0)
            {
                Instantiate(effect, transform.position, Quaternion.identity);
                player.score++;
                Debug.Log(player.score);
                Destroy(gameObject);
            }
        }
    }
}
