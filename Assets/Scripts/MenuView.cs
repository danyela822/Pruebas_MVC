using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuView : Reference
{
    public void OnClickButtons(string name_scene)
    {
        print(name_scene);
        App.generalController.menuController.OnClickButtons(name_scene);
    }
}
