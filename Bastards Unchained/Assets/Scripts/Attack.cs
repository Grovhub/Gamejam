using UnityEngine;

public class Attack : MonoBehaviour
{
    public playerMovement player;
    bool attack = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Kick") && GetComponent<BoxCollider2D>())
        {
            Debug.Log("destory");
            Destroy(gameObject,0.2f);
        }
    }

}
