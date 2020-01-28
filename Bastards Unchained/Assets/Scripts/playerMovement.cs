using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public Attack att;
    public float runSpeed = 30f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    public bool kick = false;


    // Update is called once per frame
    void Update()
    {
		allEnemyDeadCheck();

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove) );

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true); 
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
        if (Input.GetButtonDown("Kick"))
        {
            kick = true;
            animator.SetBool("IsKicking", true);
        }
        else 
        {
            kick = false;
            animator.SetBool("IsKicking", false);
        }

      
    }

    public void Onlanding()
    {
        animator.SetBool("IsJumping", false);
    }   

    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

	void allEnemyDeadCheck()
	{
		GameObject[] enemy = GameObject.FindGameObjectsWithTag("Enemy");
		print(enemy.Length);
		if (enemy.Length == 0)
		{
			SceneManager.LoadScene("EndScreen");
		}
	}


   


}
