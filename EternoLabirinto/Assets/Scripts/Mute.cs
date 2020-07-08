using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mute : MonoBehaviour
{
    public Sprite muteOn;
    public Sprite muteOff;
    public Button muteB;

    public void mute()
    {

        AudioListener.pause = !AudioListener.pause;
        IconUpdate();
    }
    void IconUpdate()
    {
        if (AudioListener.pause == true)
        {
            muteB.GetComponent<Image>().sprite = muteOn;
        }
        if (AudioListener.pause == false)
        {
            muteB.GetComponent<Image>().sprite = muteOff;
        }
    }
}
