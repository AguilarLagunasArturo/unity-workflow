using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamBehavior : MonoBehaviour
{
    public GameObject player;
    private float offset;
    private float stdOffset = 3f;
    // Start is called before the first frame update
    void Start()
    {
        // offset = gameObject.transform.position.x - player.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        offset = gameObject.transform.position.x + player.transform.position.x;
        Debug.Log(offset);
        if (Mathf.Abs(offset) > stdOffset){
            if (offset > 0f){
                Debug.Log("Triggered Right");
                gameObject.transform.position = new Vector3(
                    player.transform.position.x - stdOffset,
                    gameObject.transform.position.y,
                    gameObject.transform.position.z
                );
            }else if (offset < 0f){
                Debug.Log("Triggered Left");
                gameObject.transform.position = new Vector3(
                    player.transform.position.x + stdOffset,
                    gameObject.transform.position.y,
                    gameObject.transform.position.z
                );
            }
        }
    }
}
