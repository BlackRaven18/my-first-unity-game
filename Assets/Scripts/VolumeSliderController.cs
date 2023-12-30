using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSliderController : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    void Start()
    {
        
    }

    public void changeVolume()
    {
        AudioListener.volume = volumeSlider.value;
    }
}
