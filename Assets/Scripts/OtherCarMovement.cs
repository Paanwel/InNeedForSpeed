using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherCarMovement : MonoBehaviour
{
    //public Transform transform;
    public float speed = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, speed * Time.deltaTime, 0);

        if(transform.position.y <= -3)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
       

        if (collision.gameObject.tag == "Coin")
        {
           
            Destroy(collision.gameObject);
        }

    }
}
