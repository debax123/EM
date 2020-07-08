using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{

    public string level;


    public void GoToMenu()
    {
        SceneManager.LoadScene(level);
    }
}
