using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;
    public int health = 10;
    public int score = 0;

    public int max_shoots = 5;
    public int shoots;
    public float range=4;
    public float damage =1;
    public float startTimeBtwShoots = 0.75f;

    public int gun = 1;

    public GameObject rangeRing;

    private float timeBtwShoots;
    
    public Text healthDisplay;
    public Text scoreDisplay;
    public Text shootsDisplay;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    // Start is called before the first frame update
    void Start()
    {
        shoots = max_shoots;
        rb = GetComponent<Rigidbody2D>();
        updateGun();
    }

    // Update is called once per frame
    void Update()
    {
        healthDisplay.text = "Health : " + health;
        scoreDisplay.text = "Score : " + score;
        shootsDisplay.text = "Shoots : " + shoots;
        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (score >= 100)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        moveVelocity = moveInput.normalized * speed;

        if (shoots < max_shoots)
        {
            if (timeBtwShoots <= 0)
            {
                shoots++;
                timeBtwShoots = startTimeBtwShoots;
            }
            else
            {
                timeBtwShoots -= Time.deltaTime;
            }
        }
    }

    public void updateGun()
    {
        if (gun == 1) // pistol
        {
            startTimeBtwShoots = 0.75f;
            max_shoots = 5;
            range = 5.0f;
            damage = 1.0f;
        }
        else if (gun == 0) // mashinegun
        {
            startTimeBtwShoots = 0.25f;
            max_shoots = 10;
            range = 4.0f;
            damage = 0.75f;
        }
        else if (gun == 2) //sniperrifle
        {
            startTimeBtwShoots = 2.0f;
            max_shoots = 2;
            range = 16.0f;
            damage = 2.0f;
        }
        printRangeRing();
    }

    private void FixedUpdate()
    {
        Vector2 pos_change = rb.position + moveVelocity * Time.fixedDeltaTime;
        float xMax = 7.5f;
        float yMax = 3.5f;
        if(pos_change.x > xMax)
        {
            pos_change.x = xMax;
        } else if(pos_change.x < -xMax)
        {
            pos_change.x = -xMax;
        }
        if(pos_change.y > yMax)
        {
            pos_change.y = yMax;
        } else if (pos_change.y < -yMax)
        {
            pos_change.y = -yMax;
        }
        rb.MovePosition(pos_change);
    }

    public void printRangeRing()
    {
        Instantiate(rangeRing, rb.position, Quaternion.identity);
    }
}
