using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToSniperRifle : MonoBehaviour
{
    public void ChangeGun()
    {
        Player player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        player.gun = 2;
        player.shoots = 0;
        player.updateGun();
    }
}
