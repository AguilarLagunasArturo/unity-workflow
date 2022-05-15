using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlReal : MonoBehaviour
{
    private float deltaX = 10f;
    private float deltaY = 100f;
    private bool look = true;
    private float oldX = 0f;
    private AudioSource audioData;

    private void Flip(){
        gameObject.transform.localScale = new Vector3(
            gameObject.transform.localScale.x * -1,
            gameObject.transform.localScale.y,
            gameObject.transform.localScale.z
        );
    }

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(0f, 0f, 0f);
        oldX = gameObject.transform.position.x;
        audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        bool oldLook = look;

        // Debug.Log("Old x: " + oldX);

        // Gravity
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, deltaY * Time.deltaTime));

        // Right
        if (Input.GetKey(KeyCode.RightArrow)){
            audioData.Play(0);
            oldX = gameObject.transform.position.x;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(deltaX, 0f));
        }
        // Left
        if (Input.GetKey(KeyCode.LeftArrow)){
            audioData.Play(0);
            oldX = gameObject.transform.position.x;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-deltaX, 0f));
        }

        /*
        // Up
        if (Input.GetKey(KeyCode.UpArrow)){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 100.0f * Time.deltaTime));
        }
        // Down
        if (Input.GetKey(KeyCode.DownArrow)){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 100.0f * Time.deltaTime));
        }
        */

        Debug.Log("Diff: " + (gameObject.transform.position.x - oldX));

        if (gameObject.transform.position.x - oldX > 0)
            look = true;
        else if (gameObject.transform.position.x - oldX < 0)
            look = false;

        if (look != oldLook)
            Flip();
    }
}
