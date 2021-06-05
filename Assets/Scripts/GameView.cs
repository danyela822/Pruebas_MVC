using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameView : Reference
{
    public Canvas pause;

    void Awake()
    {
        pause = GameObject.Find("Canvas_Pause").GetComponent<Canvas>();
    }
    public void OnClickButtons(string name)
    {
        App.generalController.gameController.OnClickButtons(name);
    }
}
