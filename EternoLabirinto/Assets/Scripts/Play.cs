﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public string nameScene;
    public void sceneLoader()
    {
        TiltBall.isPaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(nameScene);
    }
}
