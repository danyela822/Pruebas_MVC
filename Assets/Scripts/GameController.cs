using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : Reference
{
    public void OnClickButtons(string name)
    {
        if(name == "Button_Pause")
        {
            App.generalView.gameView.pause.enabled = true;
        }
    }
}
