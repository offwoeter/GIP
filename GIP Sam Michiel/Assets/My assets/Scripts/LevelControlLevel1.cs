using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelControlLevel1 : MonoBehaviour
{
    // Declaratie public variabelen:
    public int index;

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

            }
        
    }
}