using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	public int maxHealth = 100;
	public int currentHealth;
	Vector3 StartPoint;
	public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
		StartPoint = transform.position;
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.E))
		{
			TakeDamage(20);
		}
		if (currentHealth == 0){
			transform.position = StartPoint;
			currentHealth = 101;
		}
		if (currentHealth == 101){
			TakeDamage(1);
		}
    }

	void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}
}
