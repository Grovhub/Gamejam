using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject gameobject;

    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 pos = new Vector3(gameobject.transform.position.x, 4.5f, -5f);
        transform.position = pos;

    }
}
