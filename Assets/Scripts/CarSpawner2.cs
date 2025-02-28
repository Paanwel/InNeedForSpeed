using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner2 : MonoBehaviour
{

    public GameObject[] car;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCars());
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Cars()
    {
        int rand = Random.Range(0, car.Length);
        float randXPos;
        
        if (Random.Range(0,2) == 0)
        {
            randXPos = Random.Range(-0.78f, -0.77f); 
        }
        else
        {
            randXPos = Random.Range(-0.44f, -0.43f); 
        }
        Instantiate(car[rand], new Vector3(randXPos, transform.position.y, -0.001f), Quaternion.Euler(0, 0, 180));
    }

    IEnumerator SpawnCars()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            Cars();
        }
    }

}