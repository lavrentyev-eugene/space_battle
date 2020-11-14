using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D player;
    private Vector3 _touchPosition;
    public int maxHealth = 5;
    public int currentHealth;
    public HealthBar healthBar; 
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void Move()
    {
        if(Input.touchCount > 0)
        {
            {
                Touch _touch = Input.GetTouch(0);
                _touchPosition = Camera.main.ScreenToWorldPoint(_touch.position);
                _touchPosition.z = 0;

                switch (_touch.phase)
                {
                    case TouchPhase.Began:
                        player.MovePosition(new Vector2(_touchPosition.x, _touchPosition.y));
                        break;

                    case TouchPhase.Stationary:
                        player.MovePosition(new Vector2(_touchPosition.x, _touchPosition.y));
                        break;

                    case TouchPhase.Moved:
                        player.MovePosition(new Vector2(_touchPosition.x, _touchPosition.y));
                        break;

                    case TouchPhase.Ended:
                        player.velocity = Vector2.zero;
                        break;
                }
            }
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
    
    void Update()
    {
        Move();            
    }
}
