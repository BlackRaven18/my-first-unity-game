using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class EndMenu : MonoBehaviour
{
    [SerializeField] private Text cherriesTextField;
    private MainManager mainManager;

    private void Start()
    {
        mainManager = MainManager.Instance;
        cherriesTextField.text += mainManager.cherries;
    }
    public void Quit()
    {
        Application.Quit();   
    }
}
