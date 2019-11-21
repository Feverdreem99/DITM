using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataformamovimiento : MonoBehaviour
{
    public Transform from;
    public Transform target;
    public float speed;
    public Transform to;

    private Vector3 start, end;
    

    void OnDrawGizmosSelected() 
    {
        if (from!=null&&to!=null)
        {
            Gizmos.color=Color.cyan;
            Gizmos.DrawLine(from.position, to.position);
        }    
    }
    
    // Start is called before the first frame update
    void Start()
    {
        if(target!=null)
        {
            target.parent=null;
            start=transform.position;
            end=target.position;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void FixedUpdate() 
    {
        if(target!=null)
        {
            float fixedSpeed= speed*Time.deltaTime;
            transform.position=Vector3.MoveTowards(transform.position, target.position, speed);
        }    

        if(transform.position==target.position)
        {
            target.position=(target.position==start) ? end: start;
        }    
    }

    
}
