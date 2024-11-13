using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CoinCounter : MonoBehaviour
{
    public static CoinCounter instance;

    public TMP_Text coinText;
    public int CurrentCoins = 0;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        coinText.text = "COINS: " + CurrentCoins.ToString();
    }

    public void IncreaseCoins()
    {
        CurrentCoins += 1;
        coinText.text = "COINS: " + CurrentCoins.ToString();
    }
}
