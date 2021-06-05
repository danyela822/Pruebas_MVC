using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralController : Reference
{
    public GameController gameController;
    public MenuController menuController;

    private void Awake()
    {
        gameController = GameObject.FindObjectOfType<GameController>();
        menuController = GameObject.FindObjectOfType<MenuController>();
    }
}
