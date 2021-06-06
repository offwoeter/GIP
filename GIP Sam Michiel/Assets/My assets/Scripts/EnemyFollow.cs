using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;

    private Transform target;
    public GameObject tar;
    public float attackDamage = 10f;
    private float attackSpeed = 1f;
    private float canAttack;

    // Start is called before the first frame update
    void Start()
    {
        target = tar.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (attackSpeed <= canAttack)
            {
                other.gameObject.GetComponent<HealthScript>().UpdateHealth(-attackDamage);
                canAttack = 0f;
            }
            else
            {
                canAttack += Time.deltaTime;
            }
        }
    }
}
