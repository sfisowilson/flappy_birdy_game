using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public float flapStreangth;
    public Rigidbody2D rigidbody;
    public logicManagerScript logic;
    private bool birdIsAlive = true;
    private float screenTop;
    private float screenBottom;


    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicManagerScript>();
        Camera mainCamera = Camera.main;

        screenTop = mainCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;
        screenBottom = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y > screenTop || gameObject.transform.position.y < screenBottom)
        {
            Dead();
        }

        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive) { 
             rigidbody.velocity = Vector2.up * flapStreangth;
        } else
        {
            //
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Dead();
    }

    private void Dead()
    {
        logic.GameOver();
        birdIsAlive = false;
    }
}
