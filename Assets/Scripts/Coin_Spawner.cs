using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Spawner : MonoBehaviour
{
    public GameObject coinPrefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CoinSpawner());
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CoinSpawn()
    {
        float randXPos = Random.Range(-0.67f, 0.26f);
        Instantiate(coinPrefab, new Vector3(randXPos, transform.position.y, -0.001f), Quaternion.Euler(0, 0, 0));
    }

    IEnumerator CoinSpawner()
    {
        while (true)
        {
            int time = Random.Range(10, 20);
            yield return new WaitForSeconds(3);
            CoinSpawn();
        }
    }
}