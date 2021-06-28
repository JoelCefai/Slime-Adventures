﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    Vector2 playerInitPosition;

    void Start()
    {
        playerInitPosition = FindObjectOfType<PlayerController>().transform.position;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}