﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorEnemigo : MonoBehaviour
{

  public int health;
  public string escena;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       if (health<=0)
       {
           Destroy(gameObject);
       }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(escena);
    }
}
