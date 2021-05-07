using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public image healthbar;
    public float max_health = 100f;
    public float cur_health = 0f;
    public bool alive = true;
    
    
    // Start is called before the first frame update
    void Start()
    {
        alive = true;
        cur_health = max_health;
        SetHealthBar ();
        InvokeRepeating("DoDamage", 1f, 5f);
    }
    void DoDamage()
    {
        TakeDamage(10f);
    }
    public void TakeDamage(float amount)
    {
        if (!alive)
        {
            return;
        }
        if(cur_health <= 0)
        {
            cur_health = 0;
            alive = false;
        }
        cur_health -= amount;
        SetHealthBar ();
    }

    // Update is called once per frame
    void Update()
    {
        float my_health = cur_health / max_health;
        healthbar.transform.localscale = new Vector3(Mathf.clamp(my_health, 0f, 1f), healthbar.transform.localscale.y, healthbar.transform.localscale.x);
    }
}
