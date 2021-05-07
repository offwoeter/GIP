using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    float speed = 200f;
    public float damage = 5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        damage = Mathf.Round(Random.Range(10f, 20f));
        other.gameobject.GetComponent<HealthScript>().TakeDamage(damage);
    }
}
