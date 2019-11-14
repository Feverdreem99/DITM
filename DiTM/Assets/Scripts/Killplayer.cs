using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Killplayer : MonoBehaviour
{
    public string escena;
    [SerializeField] Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player"))
        {
            SceneManager.LoadScene(escena);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
