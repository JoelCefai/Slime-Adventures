using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 300.0f;
    public float speed = 5.0f;
    public float maxGroundDistance = 1.5f;
    private bool isGrounded;
    public bool allowDoubleJump = false;
    private int amountOfJumps = 0;
    private bool facingRight = true;
    public float coolDown = 1;
    public float coolDownTimer;

    public Transform firePoint;
    public GameObject SlimeBallPrefab;
    public float playerCurrentSlime = 100;
    public float playerMaxSlime = 100; //You need this for the slime meter - You may or may not want to make this public.
    public float shotCost = 10;

    public PropertyMeter slimeMeter;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void LateUpdate()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, maxGroundDistance);
        if (isGrounded == true)
        {
            amountOfJumps = 0;
        }
    }

    // Update is called once per frame
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
        if (Input.GetButtonDown("Fire1") && coolDownTimer == 0)
        {
            Shoot();
            coolDownTimer = coolDown;
            //Debug.Log("Shot fired, cooldown timer reset");
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + (transform.right * speed * Time.deltaTime);
            facingRight = true;
             
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + (-transform.right * speed * Time.deltaTime);
            facingRight = false;
        }

        if (Input.GetKeyDown("space"))
        {

            if (isGrounded)
            {
                // turn on the cursor
                GetComponent<Rigidbody>().AddForce(new Vector3(0.0f, jumpForce, 0.0f));
                amountOfJumps = 1;
            }
            else if (amountOfJumps < 2 && allowDoubleJump)
            {
                // turn on the cursor
                GetComponent<Rigidbody>().AddForce(new Vector3(0.0f, jumpForce, 0.0f));
                amountOfJumps = 2;
            }

        }
    }
    
    void Shoot()
    {
        Instantiate(SlimeBallPrefab, firePoint.position, firePoint.rotation);
        playerCurrentSlime -= shotCost;
        Debug.Log(playerCurrentSlime);
        slimeMeter.UpdateMeter(playerCurrentSlime, playerMaxSlime);
    }
}
