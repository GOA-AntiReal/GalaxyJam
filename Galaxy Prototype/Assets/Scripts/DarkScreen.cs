using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DarkScreen : MonoBehaviour
{
    public bool active = false;
    public Image image;
    public GameObject titleTextImport;
    public GameObject playButtonImport;
    public GameObject howToPlayButtonImport;
    public GameObject titleScreenMusicImport;

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            image = GetComponent<Image>();
            var currentColor = image.color;
            currentColor.a += 0.0025f;
            if (currentColor.a >= 1.0f)
            {
                SceneManager.LoadScene("SampleScene");
                SceneManager.UnloadSceneAsync("TitleScreen");
            }
            image.color = currentColor;

            TMPro.TextMeshProUGUI titleText = titleTextImport.GetComponent<TMPro.TextMeshProUGUI>();
            var currentColorText = titleText.color;
            currentColorText.a -= 0.0025f;
            titleText.color = currentColorText;

            TMPro.TextMeshProUGUI playText = playButtonImport.GetComponent<TMPro.TextMeshProUGUI>();
            var currentColorplayButton = playText.color;
            currentColorplayButton.a -= 0.0025f;
            playText.color = currentColorplayButton;

            TMPro.TextMeshProUGUI howToPlayText = howToPlayButtonImport.GetComponent<TMPro.TextMeshProUGUI>();
            var currentColorHowToPlayButton = howToPlayText.color;
            currentColorHowToPlayButton.a -= 0.0025f;
            howToPlayText.color = currentColorHowToPlayButton;

            AudioSource audio = titleScreenMusicImport.GetComponent<AudioSource>();
            var currentVolume = audio.volume;
            currentVolume -= 0.0025f;
            audio.volume = currentVolume;
        }
    }
}