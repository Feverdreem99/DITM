using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorMovimiento : MonoBehaviour
{
    public float moveSpeed=5f;
    public Animator animator;

    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mvmnt = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position+= mvmnt* Time.deltaTime * moveSpeed;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            animator.SetBool("Moviendose", true);
            transform.localScale = new Vector3(0.2246417F,0.2246417F,0.2246417F);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            animator.SetBool("Moviendose", false);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            animator.SetBool("Moviendose", true);
            transform.localScale = new Vector3(-0.2246417F,0.2246417F,0.2246417F);

        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            animator.SetBool("Moviendose", false);
        }

        
    }
}
