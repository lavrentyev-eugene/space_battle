using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    public GameObject boss;
    GameObject[] bullets;
    public GameObject healthBars;
    public GameObject levelEnd;
    private void OnDestroy()
    {
        StopAllCoroutines();
        bullets = GameObject.FindGameObjectsWithTag("Bullet");
        Destroy(bullets);
        healthBars.SetActive(false);
        Time.timeScale = 0f;
        levelEnd.SetActive(true);
    }

    private void Destroy(GameObject[] bullets)
    {
        throw new NotImplementedException();
    }
}
