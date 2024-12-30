using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner2 : MonoBehaviour //po co ci zduplikowany skrypt? 
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
        float randXPos = Random.Range(-0.78f, -0.39f);
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