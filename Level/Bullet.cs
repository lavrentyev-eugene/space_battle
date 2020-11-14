using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject weapon;
    private float range;
    [SerializeField] private float maxRange = 25;
    private int bulletDamage = 2;

    private void Start()
    {
        weapon = GameObject.FindGameObjectWithTag("Weapon");        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.GetComponent<Enemy>().ApplyDamage(bulletDamage);
            Destroy(gameObject);
        }
        if (collision.CompareTag("Boss Enemy"))
        {
            collision.GetComponent<BossEnemy>().ApplyDamage(bulletDamage);
            Destroy(gameObject);
        }

        

    }
    private void RangeCheck()
    {
       
    }
    void Update()
    {
        range = transform.position.y - weapon.transform.position.y;
        if (range > maxRange)
        {
            Destroy(gameObject);
        }
    }
}
