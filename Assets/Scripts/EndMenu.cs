using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class EndMenu : MonoBehaviour
{
    [SerializeField] private Text cherriesTextField;

    private void Start()
    {
        cherriesTextField.text += MainManager.Instance.cherries;
    }
    public void Quit()
    {
        Application.Quit();   
    }
}
