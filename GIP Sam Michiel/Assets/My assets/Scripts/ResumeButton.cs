using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeButton : MonoBehaviour
{
    private int sceneToResume;
    public void ResumeGame()
    {
        sceneToResume = PlayerPrefs.GetInt("SavedScene");
        if (sceneToResume != 0)
        {
            SceneManager.LoadScene(sceneToResume);
        }
        else return;
        
    }
}


