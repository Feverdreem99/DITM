using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorMovimiento : MonoBehaviour
{
  
  public float speed;
  public float moveSpeed = 5f;
  private Rigidbody2D rb;
  private Animator anim;
  public bool isGrounded=false;


    // Start is called before the first frame update

    void Start()
    {
        anim= GetComponent<Animator>();
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        
        float moveInput= Input.GetAxisRaw("Horizontal");
        rb.velocity=new Vector2(moveInput*speed, rb.velocity.y);
        Vector3 movement= new Vector3(Input.GetAxis("Horizontal"),0f,0f);
        transform.position+= movement*Time.deltaTime*moveSpeed;
        
        if (moveInput==0 || isGrounded==false)
        {
            anim.SetBool("Moviendose",false);
        }
        else
        {
            anim.SetBool("Moviendose",true);

        }

        if (moveInput<0)
        {
            transform.eulerAngles=new Vector3(0,0,0);
        }
        else if (moveInput>0)
        {
            transform.eulerAngles= new Vector3(0,180,0);   
        }

        void Jump()
        {
            if (Input.GetButtonDown("Jump") && isGrounded==true)
            {   
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f,7f), ForceMode2D.Impulse);
            }
            else if(isGrounded==false)
            {
                StartCoroutine(stopJump());
            }
            

            
        }

        
    
        IEnumerator stopJump()
        {
                anim.SetBool("Saltando",true);
                yield return new WaitForSeconds(.1f);
                anim.SetBool("Saltando",false);

        }


        
    }
}
