using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slimeball : MonoBehaviour
{
	public float speed = 20f;
	public int damage = 100;
	public Rigidbody rb;
	public GameObject impactEffect;


	void Start()
	{
	rb.velocity = transform.right * speed;
		{

		}

	}

	void OnTriggerEnter3D(Collider hitInfo)
	{
		Enemy enemy = hitInfo.GetComponent<Enemy>();
		if (enemy != null)
		{
			enemy.TakeDamage(damage);
		}

		Instantiate(impactEffect, transform.position, transform.rotation);

		Destroy(gameObject);
	}


}
