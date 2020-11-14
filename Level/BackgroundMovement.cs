using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BackgroundMovement : MonoBehaviour
{   
    private GameObject[] _backgroundImages;
    [SerializeField] private float _backgroundSpeed = (float)0.01;
    
    void Start()
    { 
        _backgroundImages = GameObject.FindGameObjectsWithTag("Background");
    }
    void Update()
    {
        foreach (GameObject _image in _backgroundImages)
        {
            _image.transform.Translate(0, -_backgroundSpeed, 0);
            if (_image.transform.position.y < -32)
            {
                _image.transform.Translate(0, 64, 0);
            }
        }  
    }
}
