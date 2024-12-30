using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CoinCounter : MonoBehaviour
{
    public static CoinCounter instance;

    [SerializeField]
    private TMP_Text coinText;


    private int currentCoins = 0; //ta zmienna nie musi być publiczna, jeśli chcesz aby inne skrypty miał do niej dostęp użyj parametetru (gettera)
    public int CurrentCoins => currentCoins;

    private void Awake()
    {
        if(instance == null) //dodaj zabezpieczenie do singletona
        {
            instance = this;
        } 
        else Destroy(gameObject);
    }
    // Start is called before the first frame update //usuwaj domyślne komentarze
    void Start()
    {
        coinText.text = "COINS: " + currentCoins.ToString();
    }

    public void IncreaseCoins()
    {
        currentCoins += 1;
        coinText.text = "COINS: " + currentCoins.ToString();
    }
}
