using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeButtonColor : MonoBehaviour
{
    public Button maschineButton;
    public Button pistolButton;
    public Button sniperButton;
    // Update is called once per frame

    private void Start()
    {
        changeColor();
    }
    public void changeColor()
    {
        Player player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        int gun = player.gun;
        if (gun == 0)
        {
            maschineButton.GetComponent<Image>().color = Color.red;
            pistolButton.GetComponent<Image>().color = Color.white;
            sniperButton.GetComponent<Image>().color = Color.white;
        }
        else if (gun == 1)
        {
            maschineButton.GetComponent<Image>().color = Color.white;
            pistolButton.GetComponent<Image>().color = Color.red;
            sniperButton.GetComponent<Image>().color = Color.white;
        }
        else if (gun == 2)
        {
            maschineButton.GetComponent<Image>().color = Color.white;
            pistolButton.GetComponent<Image>().color = Color.white;
            sniperButton.GetComponent<Image>().color = Color.red;
        }
    }
}
