using Assets.Scripts.Architecture.Facades;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(PlayerFacade.Coins);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            PlayerFacade.AddCoins(10);
            Debug.Log(PlayerFacade.Coins);
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            PlayerFacade.SpendCoins(10);
            Debug.Log(PlayerFacade.Coins);
        }
    }
}
