
using System;
using UnityEngine;
using UnityEngine.UI;

public class SoundButtonController : MonoBehaviour
{
    private MainManager mainManager;

    [SerializeField] private Slider volumeSlider;
    [SerializeField] private Sprite SoundImageOn;
    [SerializeField] private Sprite SoundImageOff;

    private AudioSource backgroundMusic;

    private void Start()
    {
        mainManager = MainManager.Instance;
        backgroundMusic = GetComponent<AudioSource>();
        checkIfShouldPlay();
    }

    public void manageButtonIcon()
    {
        Console.WriteLine(AudioListener.volume);
        if(AudioListener.volume <= 0)
        {
            gameObject.GetComponent<Image>().sprite = SoundImageOff;
        }
        else
        {
            gameObject.GetComponent<Image>().sprite = SoundImageOn;
        }
    }

    private void checkIfShouldPlay()
    {
        if (mainManager.playBackgroundMusic)
        {
            backgroundMusic.Play();
            gameObject.GetComponent<Image>().sprite = SoundImageOn;
        }
        else
        {
            backgroundMusic.Stop();
            gameObject.GetComponent<Image>().sprite = SoundImageOff;
        }
    }

    public void SwitchOnOff()
    {

        volumeSlider.gameObject.SetActive(!volumeSlider.gameObject.activeSelf);
       
/*
        if (mainManager.playBackgroundMusic)
        {
            mainManager.playBackgroundMusic = false;
            backgroundMusic.Stop();
            gameObject.GetComponent<Image>().sprite = SoundImageOff;
        }
        else
        {
            mainManager.playBackgroundMusic = true;
            backgroundMusic.Play();
            gameObject.GetComponent<Image>().sprite = SoundImageOn;
        }*/
    }





}
