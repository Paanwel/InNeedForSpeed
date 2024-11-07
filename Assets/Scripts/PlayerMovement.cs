using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform transform;
    public float speed = 5.0f;
    public float rotationSpeed = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 47), rotationSpeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, -47), rotationSpeed * Time.deltaTime);
        }
        if (transform.rotation.z !=90)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 0), rotationSpeed * Time.deltaTime);
        }
    }
    void Clamp()
    {
        // unity inbuild feature
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -2.71f, 2.8f);
        transform.position = pos;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Car")
        Debug.Log("Kolizja!!!!!!!!!!");

        if (collision.gameObject.name == "Car 1")
            Debug.Log("Kolizja!!!!!!!!!!");

        if (collision.gameObject.name == "Car 2")
            Debug.Log("Kolizja!!!!!!!!!!");
    }
}
