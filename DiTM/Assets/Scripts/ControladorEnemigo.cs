using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorEnemigo : MonoBehaviour
{

    public float speed;
  public float moveSpeed = 5f;
  public int health;
  private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       transform.position += Vector3.right*Time.deltaTime;

       if (health<=0)
       {
           Destroy(gameObject);
       }
    }
}
