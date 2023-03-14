using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeToMaschinegun : MonoBehaviour
{

    public void ChangeGun()
    {
        Player player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        player.gun = 0;
        player.shoots = 0;
        player.updateGun();
    }
}
