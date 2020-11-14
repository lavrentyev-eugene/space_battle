using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] public int enemyDamage = 1;
    [SerializeField] public int maxHealth = 10;
    [SerializeField] private GameObject player;
    public int _speed = 3;
    public int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<Player>().ApplyDamage(enemyDamage);
            Destroy(gameObject);
        }
    }

    public void ApplyDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void FollowPlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, _speed * Time.deltaTime);
    }
    void Update()
    {
        FollowPlayer();
    }
}