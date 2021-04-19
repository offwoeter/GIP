using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    // Declaratie public variabelen:
    public int index;
    public string levelName;

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            /* Mogelijkheid 1: Scene laden a.h.v. build index van de scene.
             * De build index wordt nu bepaald door de waarde van de public
             * variabele index.             
             */

            SceneManager.LoadScene(index);

            /* Mogelijkheid 2: Scene laden a.h.v. naam van de scene.
             * De naam wordt nu bepaald door de waarde van de public
             * variabele levelName.   
             */

            //SceneManager.LoadScene(levelName);


        }
    }
}