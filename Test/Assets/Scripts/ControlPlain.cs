using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlain : MonoBehaviour
{
    private float delta = 0.2f;
    private bool look = true;

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
    }

    // Update is called once per frame
    void Update()
    {
        float oldX = gameObject.transform.position.x;
        bool oldLook = look;

        // Gravity
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 100.0f * Time.deltaTime));

        // Right
        if (Input.GetKey(KeyCode.RightArrow)){
            gameObject.transform.position = new Vector3(
                gameObject.transform.position.x + delta,
                gameObject.transform.position.y,
                gameObject.transform.position.z
            );
        }
        // Left
        if (Input.GetKey(KeyCode.LeftArrow)){
            gameObject.transform.position = new Vector3(
                gameObject.transform.position.x - delta,
                gameObject.transform.position.y,
                gameObject.transform.position.z
            );
        }
        // Up
        if (Input.GetKey(KeyCode.UpArrow)){
            gameObject.transform.position = new Vector3(
                gameObject.transform.position.x,
                gameObject.transform.position.y + delta,
                gameObject.transform.position.z
            );
        }
        // Down
        if (Input.GetKey(KeyCode.DownArrow)){
            gameObject.transform.position = new Vector3(
                gameObject.transform.position.x,
                gameObject.transform.position.y - delta,
                gameObject.transform.position.z
            );
        }

        if (gameObject.transform.position.x - oldX > 0)
            look = true;
        else if (gameObject.transform.position.x - oldX < 0)
            look = false;

        if (look != oldLook)
            Flip();
    }
}
