using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalk : MonoBehaviour
{
    public float speed = 10f;
    private bool m_FacingRight = true;
    int random;
    bool left = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int random = Random.Range(0, 9);
        if (random > 4)
        {
            if (left == false)
            {
                if (transform.position.x < 10f)
                {
                    transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
                    if (transform.position.x > 9f)
                    {
                        left = true;
                        Debug.Log(left);
                    }
                }
            }
        }
            if (left == true)
            {
                if (transform.position.x < 10f)
                {
                    speed = -speed;
                    Debug.Log(speed);
                    transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
                    if (transform.position.x > -10f)
                    {
                        left = false;
                    }
                }
            }

        if (speed > 0 && !m_FacingRight)
        {
            // ... flip the player.
            Flip();
        }
        // Otherwise if the input is moving the player left and the player is facing right...
        else if (speed < 0 && m_FacingRight)
        {
            // ... flip the player.
            Flip();
        }





    }






    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        m_FacingRight = !m_FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }



}
