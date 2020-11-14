using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnemy : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private HealthBar healthBar;
    [SerializeField] private GameObject bossHealthbar;
    public int enemyDamage = 5;
    public int maxHealth = 100;
    public int currentHealth;
    private GameObject[] bullets;
    public GameObject healthBars;
    public GameObject levelEnd;


    public int _speed = 2;

    private void Start()
    {
        bossHealthbar.SetActive(true);
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<Player>().ApplyDamage(enemyDamage);
        }
    }
    private void DestroyBullets()
    {
        bullets = GameObject.FindGameObjectsWithTag("Bullet");
        foreach (GameObject bullet in bullets)
        {
            Destroy(bullet);
        }
    }
    public void ApplyDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void FollowPlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, _speed * Time.deltaTime);
    }

    void Update()
    {
        FollowPlayer();
    }
    private void OnDestroy()
    {
        StopAllCoroutines();
        DestroyBullets();
        healthBars.SetActive(false);
        Time.timeScale = 0f;
        levelEnd.SetActive(true);
    }
}