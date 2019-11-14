using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataformamovil : MonoBehaviour
{
    public Transform target;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void fixedUpdate()
    {
        if (target!=null)
        {
            float fixedSpeed=speed*Time.deltaTime;
            transform.position=Vector3.MoveTowards(transform.position, target.position, speed);
        }
    }
}
