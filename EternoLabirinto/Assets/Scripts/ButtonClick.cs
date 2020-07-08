using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public AudioSource click;
    // Update is called once per frame
    public void PlayClick()
    {
        click.Play();
    }
}
