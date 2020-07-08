using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPanel : MonoBehaviour
{
    [SerializeField] private Animator winPanelController;
    public ParticleSystem rocketFire;
    public ParticleSystem rocketFire2;


    void OnTriggerEnter(Collider other)
    {
        rocketFire.Play();
        rocketFire2.Play();
        winPanelController.SetBool("PlayWinPanel", true);
    }
}
