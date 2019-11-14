using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pasarescena : MonoBehaviour
{
    public string Escena;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Scenepass()
    {
        SceneManager.LoadScene(Escena);
    }

    public void AccessNextScene()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Scenepass();
        }
    }

    // Update is called once per frame
    void Update()
    {
        AccessNextScene();
    }
}
