using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    //Variables
    private float playerCurrentSlime = 100;
    private float playerMaxSlime = 100;
    public PropertyMeter slimeMeter;

    private void Start()
    {
        playerCurrentSlime = playerMaxSlime; // set current health to initial value, max health
    }
    /*public void TakeDamage(int damage)
    {
        playerCurrentSlime -= damage;
        slimeMeter.UpdateMeter(playerCurrentSlime, playerMaxSlime);
    } */

    void Update()
    {
        if (playerCurrentSlime <= 0)
        {
            playerCurrentSlime = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }

        if (playerCurrentSlime == 0)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
