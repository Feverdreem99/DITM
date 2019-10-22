using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAtaque : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    public bool isGrounded=false;

    public Transform attackpos;
    public LayerMask spec2Enemies;
    public float attackRange;
    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        anim= GetComponent<Animator>();
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
        jumpAttack();
        void Attack()
        {
            if(Input.GetKeyDown("z"))
            {
                anim.SetBool("Atacando",true);
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackpos.position, attackRange, spec2Enemies);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<ControladorEnemigo>().health-=damage;   
                }
            }
            if (Input.GetKeyUp("z"))
            {
                anim.SetBool("Atacando",false);
            }
        }
        void jumpAttack()
        {
            if (isGrounded==false && anim.GetCurrentAnimatorStateInfo(0).IsName("DJump") && Input.GetKeyDown("z"))
            {
                anim.Play("DAttack");

            }
        }

         void OnDrawGizmosSelected() {
            Gizmos.color= Color.red;
            Gizmos.DrawWireSphere(attackpos.position, attackRange);
        }
    }
}
