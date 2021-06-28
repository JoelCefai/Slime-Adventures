using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireShot : MonoBehaviour { 
	
	public Transform firePoint;
	public GameObject SlimeBallPrefab;
	public float playerCurrentSlime = 100;
	public float playerMaxSlime = 100; //You need this for the slime meter - You may or may not want to make this public.
	public float shotCost = 10;
	public float coolDown = 1;
	public float coolDownTimer;

	public PropertyMeter slimeMeter;


	// Update is called once per frame
	void Update()
	{
		/*if (coolDownTimer > 0)
		{
			coolDownTimer -= Time.deltaTime;
		}

		if (coolDownTimer < 0)
		{
			coolDownTimer = 0;
		}
		if (Input.GetButtonDown("Fire1") && coolDownTimer == 0)
		{
			Shoot();
			coolDownTimer = coolDown;
			//Debug.Log("Shot fired, cooldown timer reset");
		}*/
	}

	public void Shoot()
	{
		Instantiate(SlimeBallPrefab, firePoint.position, firePoint.rotation);
		playerCurrentSlime -= shotCost;
		Debug.Log(playerCurrentSlime); 
		slimeMeter.UpdateMeter(playerCurrentSlime, playerMaxSlime);
	}
}
