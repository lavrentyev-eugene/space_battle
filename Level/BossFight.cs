using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFight : MonoBehaviour
{
    [SerializeField] private GameObject Boss;
    private void Start()
    {
        GameObject.Find("Boss");
    }
    void Update()
    {
        if (gameObject.transform.childCount == 0)
        {
            Boss.SetActive(true);
        }
    }
}
