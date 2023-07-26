using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    //private int cherries = 0;

    [SerializeField] private Text cherriesText;
    [SerializeField] private AudioSource collectionSoundEffect;

    private MainManager mainManager;

    private void Start()
    {
        mainManager = MainManager.Instance;
        cherriesText.text = "Cherries: " + mainManager.cherries;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            Destroy(collision.gameObject);
            collectionSoundEffect.Play();
            mainManager.cherries++;
            cherriesText.text = "Cherries: " + mainManager.cherries;
        }   
    }
}
