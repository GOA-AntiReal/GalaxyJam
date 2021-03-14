using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDarkScreen : MonoBehaviour
{
    public Image image;
    public GameObject GameMusicImport;

    // Update is called once per frame
    void Update()
    {
        image = GetComponent<Image>();
        var currentColor = image.color;
        currentColor.a -= 0.0025f;
        image.color = currentColor;

        AudioSource audio = GameMusicImport.GetComponent<AudioSource>();
        var currentVolume = audio.volume;
        currentVolume += 0.0025f;
        audio.volume = currentVolume;
    }
}