using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    public void Move()
    {
        float moveforward = Input.GetAxis("Vertical") * speed * Time.deltaTime; 
        Debug.Log("move forward: " + moveforward);
        float movesideways = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        Debug.Log("move sideways: " + movesideways);
        Vector3 pos = new Vector3(movesideways, 0f, moveforward);
        transform.position += pos;
    }
}
