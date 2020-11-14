using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    [SerializeField] private Rigidbody2D bullet;
    [SerializeField] private GameObject weapon;
    [SerializeField] private float _bulletSpeed = 500f;
    [SerializeField] private float _fireRate = 1f;
    private IEnumerator ToDamage()
    {
        while (true)
        {
            var _spawnedBullet = Instantiate(bullet, weapon.transform.position, weapon.transform.rotation);
            _spawnedBullet.AddForce(weapon.transform.up * _bulletSpeed);
            yield return new WaitForSeconds(1/_fireRate);
        }
    }
    void Start()
    {
        StartCoroutine(ToDamage());     
    }

} 