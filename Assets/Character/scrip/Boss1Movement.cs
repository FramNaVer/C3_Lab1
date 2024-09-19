using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1Movement : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    CharacterController controller;
   
    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();;

        anim.SetBool("isDef", true);
        anim.SetBool("isWalking", true);
        anim.SetBool("isDancing", true);
        //Time to start the animation
        Time.timeScale = 1;

        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            anim.SetBool("isWalking",true);
            anim.SetBool("isDef",true);
            anim.SetBool("isDancing",false);

        }
        else if(Input.GetKey(KeyCode.D)){
            anim.SetBool("isDancing",true);
            anim.SetBool("isWalking",true);
            anim.SetBool("isDef",false);
        }

        else if(Input.GetKey(KeyCode.A)){
            anim.SetBool("isDef",true);
            anim.SetBool("isDancing",true);
            anim.SetBool("isWalking",false);
        }

        else if(Input.GetKey(KeyCode.S)){
            anim.SetBool("isDef",true);
            anim.SetBool("isDancing",false);
            anim.SetBool("isWalking",false);
        }

        else if(Input.GetKey(KeyCode.E)){
            anim.SetBool("isDef",false);
            anim.SetBool("isDancing",false);
            anim.SetBool("isWalking",true);
        }

        else if(Input.GetKey(KeyCode.Q)){
            anim.SetBool("isDef",false);
            anim.SetBool("isDancing",true);
            anim.SetBool("isWalking",false);
        }


        
    }
}
