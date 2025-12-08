using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWallet : MonoBehaviour
{
    private List<Coin> _coins = new List<Coin>();

    public event Action<Coin> OnCoinChanged;

    public void AddCoin(Coin coin)
    {
        _coins.Add(coin);
        OnCoinChanged?.Invoke(coin);
    }
}