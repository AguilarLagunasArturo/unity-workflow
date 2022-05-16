using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
public class ControlReal : MonoBehaviour
{
    // Objs
    private AudioSource audioData;

    // Vars
    private float stdForceX = 500f;     // force in x axis
    private float stdForceY = 100f;     // Force in y axis
    private bool stdDirection = true;   // Is looking to the right
    private bool jumping = false;       // Is jumping

    // Mirror image
    private void Flip(){
        gameObject.transform.localScale = new Vector3(
            gameObject.transform.localScale.x * -1,
            gameObject.transform.localScale.y,
            gameObject.transform.localScale.z
        );
        stdDirection = !stdDirection;
    }

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(0f, 0f, 0f);
        audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // Gravity
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, -stdForceY * Time.deltaTime));

        // Right
        if (Input.GetKey(KeyCode.RightArrow)){
            if (!stdDirection)
                Flip();
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(stdForceX * Time.deltaTime, 0f));
        }
        // Left
        if (Input.GetKey(KeyCode.LeftArrow)){
            if (stdDirection)
                Flip();
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-stdForceX * Time.deltaTime, 0f));
        }
        // Space
        if (Input.GetKey(KeyCode.Space) && !jumping){
            Debug.Log("Jump");
            jumping = true;
            audioData.Play(0);
            gameObject.GetComponent<Rigidbody2D>().AddForce(
                new Vector2(0f, (stdForceY * (1f + 80f)) * Time.deltaTime));
        }

        // Print position
        /*Debug.Log(String.Format("Pos: <{0}, {1}, {2}>",
            gameObject.transform.position.x,
            gameObject.transform.position.y,
            gameObject.transform.position.z
        ));*/
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.transform.tag == "Solid")
            jumping = false;
    }
}
