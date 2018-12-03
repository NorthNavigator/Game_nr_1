using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float speed = 5f;
    public float height = 5f;

    public bool grounded = false;

    private Rigidbody2D rb;



    private void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }




    // Update is called once per frame
    void FixedUpdate ()
    {
	    if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
  
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if(grounded == true)
            {
                rb.velocity = new Vector2(0f, height);
            }
            

        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        grounded = true;
    }


    void OnTriggerExit2D(Collider2D other)
    {
        grounded = false;
    }


}
