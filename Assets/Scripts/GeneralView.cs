using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneralView : Reference
{
    public GameView gameView;
    public MenuView menuView;
    /**
     * Faltan mas vistas
     * */

    private void Awake()
    {
        gameView = GameObject.FindObjectOfType<GameView>();
        menuView = GameObject.FindObjectOfType<MenuView>();
    }
}
