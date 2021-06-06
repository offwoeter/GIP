using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{

    public float max_Health = 100f;
    public float cur_Health = 0f;
    public GameObject healthBar;
    // Start is called before the first frame update
    void Start()
    {
        cur_Health = max_Health;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void UpdateHealth(float mod)
    {
        cur_Health += mod;
        if(cur_Health > max_Health)
        {
            cur_Health = max_Health;
        }
        else if( cur_Health <= 0f)
        {
            cur_Health = 0f;
            Debug.Log("Mission Failed");
        }
    }
    public void SetHealthBar(float myHealth)
    {
        healthBar.transform.localScale = new Vector3(myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }
}
