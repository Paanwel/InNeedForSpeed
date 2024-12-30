using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject[] car; 
    // Start is called before the first frame update
    private void Start() //dodawaj modyfikator dostępu do metod
    {
        StartCoroutine(SpawnCars());
    }

    // Update is called once per frame
    void Update() //usuwaj puste lub nieużywane metody
    {
        
    }

    void Cars()
    {
        int rand = Random.Range(0, car.Length);
        float randXPos = Random.Range(-0.06f, 0.20f); //zamień magic numbers na zmienne dostępne w inspektorze lub const
        Instantiate(car[rand], new Vector3(randXPos, transform.position.y, -0.001f), Quaternion.Euler(0, 0, 0));
    }

    IEnumerator SpawnCars()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            Cars();
        }
    }

}
