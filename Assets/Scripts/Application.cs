using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Application : MonoBehaviour
{
    public GeneralController generalController;
    public GeneralView generalView;
    public GeneralModel generalModel;
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        DontDestroyOnLoad(generalView.gameObject);
        DontDestroyOnLoad(generalController.gameObject);
        DontDestroyOnLoad(generalModel.gameObject);
    }
}
