using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWin : MonoBehaviour
{
    public GameObject wintext;
    // Start is called before the first frame update
    void Start()
    {
        wintext.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Plate"))
        {
            WinWindow();
        }
    }
    public void WinWindow()
    {
        //AnimationEvent();
    }

}
