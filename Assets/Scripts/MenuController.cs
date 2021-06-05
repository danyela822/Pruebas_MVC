using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : Reference
{
    public void OnClickButtons(string name_scene)
    {
        SceneManager.LoadScene(name_scene);        
    }
}
