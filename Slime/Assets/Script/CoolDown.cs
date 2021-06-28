using System.Collections;
using UnityEngine;

public class CoolDown : MonoBehaviour
{

    public float coolDown = 1;
    public float coolDownTimer;

    void Update()
    {

        if (coolDownTimer > 0)
        {
            coolDownTimer -= Time.deltaTime;
        }

        if (coolDownTimer < 0)
        {
            coolDownTimer = 0;
        }

        if (Input.GetButton("Fire1") && coolDownTimer == 0)
        {
            Attack();
            coolDownTimer = coolDown;

        }



    }

    void Attack()
    {
        Debug.Log("Hi!");

    }

}