using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlaygunShot(AudioSource gunShot)
    {
        gunShot.Play();
    }
}
