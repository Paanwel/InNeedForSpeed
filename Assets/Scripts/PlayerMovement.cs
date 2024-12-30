using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    //te zmienne nie muszą być publiczne
    public Transform transform;
    public float speed = 5.0f;
    public float rotationSpeed = 4.0f;
    public GameObject gameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
        gameOverPanel.SetActive(false);
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
        Clamp();
    }
    void Clamp()
    {
        
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -0.77f, 0.26f); //magic numbers
        transform.position = pos; 
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Cars")
        {

            gameOverPanel.SetActive(true);
            Debug.Log("Crash");
            Time.timeScale = 0; //time scale porozrzucany po kilku skryptach może utrudnić debugowanie. Najlepiej jakby czas kontrolowal tylko jeden skrypt np GameManager 
        }

        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
        }

    }
}
