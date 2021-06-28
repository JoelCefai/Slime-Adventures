﻿using System.Collections;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform RespawnPoint;

    void OnTriggerEnter(Collider other)
    {
        player.transform.position = RespawnPoint.transform.position;
    }

}
