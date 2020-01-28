using UnityEngine;

public class Attack : MonoBehaviour
{
   // public playerMovement player;
    public GameObject player;
    bool attack = false;
    public float dist;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        dist = transform.position.x - player.transform.position.x;
        Debug.Log(dist);
        if (dist < 1.5f && dist > -1.5f)
        {
            if (Input.GetButtonDown("Kick") && this.GetComponent<BoxCollider2D>())
            {
                Debug.Log("destory");
                Destroy(this.gameObject, 0.1f);
                score += 1;
         
            }
        }
    }





}
