using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tut1Play : MonoBehaviour
{
    public Animator victory;
    public Animator pause;
    public bool playing;
    public Animator tut1TextUp;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(timer4Animations());
    }

    // Update is called once per frame
    void Update()
    {
        if (TiltBall.isPaused == true)
        {
            pause.updateMode = AnimatorUpdateMode.UnscaledTime;
            Time.timeScale = 0;
        }
        if (TiltBall.isPaused == false)
        {
            Time.timeScale = 1;
        }
        if (victory.GetBool("Victory") == true)
        {
            tut1TextUp.SetBool("IsTime", false);
            tut1TextUp.SetBool("Tex3Maintain", false);
            tut1TextUp.SetBool("Tex4Maintain", false);
            StopAllCoroutines();
        }
    }
    public IEnumerator timer4Animations()
    {
        yield return new WaitForSeconds(1f);
        tut1TextUp.SetBool("IsTime", true);
        yield return new WaitForSeconds(20f);
        tut1TextUp.SetBool("IsTime", false);
        StartCoroutine(Text3());
    }
    public IEnumerator Text3()
    {
        yield return new WaitForSeconds(2f);
        tut1TextUp.SetBool("Tex3UP", true);
        yield return new WaitForSeconds(0.5f);
        tut1TextUp.SetBool("Tex3Maintain", true);
        yield return new WaitForSeconds(10f);
        tut1TextUp.SetBool("Tex3Maintain", false);
        yield return new WaitForSeconds(2f);
        tut1TextUp.SetBool("Tex4", true);
        yield return new WaitForSeconds(0.5f);
        tut1TextUp.SetBool("Tex4Maintain", true);
        yield return new WaitForSeconds(10f);
        tut1TextUp.SetBool("Tex4Maintain", false);
    }
    public void closeTut1()
    {
        tut1TextUp.SetBool("IsTime", false);
        StartCoroutine(Text3());
    }
}
