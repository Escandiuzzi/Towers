using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScript : MonoBehaviour {
    [SerializeField]
    bool playable;

    public float value;
    public float gValue;
	
    // Use this for initialization
	void Start () {
        playable = true;
	}
	
	// Update is called once per frame
	void Update () {

        if (playable)
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                gameObject.transform.position = gameObject.transform.position + new Vector3(value, 0);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                gameObject.transform.position = gameObject.transform.position + new Vector3(-value, 0);
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                gameObject.GetComponent<Rigidbody2D>().gravityScale += gValue;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                transform.Rotate(Vector3.forward * -90);
            }


        }

	}

    public bool GetStatus()
    {
        return playable;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        var col = collision.gameObject;

        if (col.tag == "Object")
        {
            playable = false;
        }
    }
}
