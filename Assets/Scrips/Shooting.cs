using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject shot;
    public AudioSource gunShot;

    private Player player;

    private Transform playerPos;
    // Start is called before the first frame update
    void Start()
    {
        playerPos = GetComponent<Transform>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && player.shoots > 0)
        {
            Instantiate(shot, playerPos.position, Quaternion.identity);
            player.shoots--;
            PlaygunShot();
        }
    }

    private void PlaygunShot()
    {
        gunShot.Play();
    }
}
