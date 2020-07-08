using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinSound : MonoBehaviour
{
    public static AudioClip winSound;
    static AudioSource win;
    // Start is called before the first frame update
    void Start()
    {
        winSound = Resources.Load<AudioClip>("VictorySound5");

        win = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void PlayWinSound()
    {
        win.PlayOneShot(winSound);
    }
}
