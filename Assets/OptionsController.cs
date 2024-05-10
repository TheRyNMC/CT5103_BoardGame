using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {
    float masterAudio;
    public GameController GameController;

    //A list of audio sources that need to be added by hand
    [SerializeField]
    private AudioSource[] speakers;
    // Start is called before the first frame update
    void Awake()
    {
        //Collect the volume setting from player preferences
        masterAudio = GetFloat("volume");
        //Collects all the objects with AudioSource and adds to the array
        speakers = FindObjectsOfType<AudioSource>();
        //Set voulme of all speakers
        UpdateSpeakers(masterAudio);
    }

    //Player prefs
    public void SetFloat(string Keyname, float value)
    {
        PlayerPrefs.SetFloat(Keyname, value);
    }

    public float GetFloat(string Keyname)
    {
        return PlayerPrefs.GetFloat(Keyname);
    }

    // Update is called once per frame
    public void SliderValueUpdate(Slider slider)
    {
        masterAudio = slider.value;

        SetFloat("volume", masterAudio);
        //OR PlayerPrefs.SetFloat("volume", masterAudio)

        UpdateSpeakers(masterAudio);
    }

    public void UpdateSpeakers(float volume)
    {
        foreach (AudioSource speaker in speakers)
        {
            speaker.volume = volume;
        }
    }
    public void QuitGame(){
        Application.Quit();
    }

    public void ResetTile(){
        GameController.ResetTiles();
    }

    public void ResetScene(string sceneManager){
        SceneManager.LoadScene(sceneManager);
    }
}
