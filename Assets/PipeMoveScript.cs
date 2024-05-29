using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float MoveSpeed = 1.0f;
    public float DeadZone = -5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < DeadZone)
        {
            Destroy(gameObject);
        } else
        {
            transform.position = transform.position + (Vector3.left * MoveSpeed * Time.deltaTime);
        }
    }
}
