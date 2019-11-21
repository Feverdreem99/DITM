using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Grounded : MonoBehaviour
{
    public int playerHealth=3;
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player=gameObject.transform.parent.gameObject;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
       if(collisionInfo.collider.tag=="piso")
       {
         Player.GetComponent<ControladorMovimiento>().isGrounded= true;
         Player.transform.parent=collisionInfo.transform;

       }

       if (collisionInfo.collider.tag=="Enemigo")
            {
                playerHealth-=1;
            }
            if (playerHealth<1)
            {
                SceneManager.LoadScene("GameOver");
            }    

       
    }

     void OnTriggerEnter2D(Collider2D other) 
     {
        if (other.gameObject.tag.Equals("Enemigo"))
            {
                playerHealth-=1;
                
            }
            if (playerHealth<1)
            {
                SceneManager.LoadScene("GameOver");
            }    
     }

    void OnCollisionExit2D(Collision2D collisionInfo)
    {
        if(collisionInfo.collider.tag=="piso")
       {
           Player.GetComponent<ControladorMovimiento>().isGrounded= false;
       }
    }
}
