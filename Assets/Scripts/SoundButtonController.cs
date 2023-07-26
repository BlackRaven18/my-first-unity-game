
using UnityEngine;
using UnityEngine.UI;

public class SoundButtonController : MonoBehaviour
{
    private MainManager mainManager;

    
    [SerializeField] private Sprite SoundImageOn;
    [SerializeField] private Sprite SoundImageOff;

    private AudioSource backgroundMusic;

    private void Start()
    {
        mainManager = MainManager.Instance;
        backgroundMusic = GetComponent<AudioSource>();
        checkIfShouldPlay();
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
        }
    }




}
