using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;
using UnityEngine.UI;

public class SettingsController : MonoBehaviour {
    [SerializeField] PinchSlider slider;
    
    private float savedVolume;
    private float selectedVolume;

    void Start() {
        savedVolume = PlayerPrefs.GetFloat("BackgroundMusicVolume",1);
        selectedVolume = savedVolume;
        LoadVolume(savedVolume);
    }
    void LoadVolume(float volume) {
        slider.SliderValue = volume;
    }


    public void ChangeVolume()
    {
        Debug.Log("selectedVolumeo " + selectedVolume);
        Debug.Log("SliderValue " + slider.SliderValue);
        if (selectedVolume != slider.SliderValue)
        {
            selectedVolume = slider.SliderValue;
            AudioManager.instance.ChangeVolume(slider.SliderValue);
            PlayerPrefs.SetFloat("BackgroundMusicVolume", selectedVolume);
        }
    }


    public void SaveSettings() { 
        PlayerPrefs.Save();
    }
}