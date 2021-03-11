using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToPlayButton : MonoBehaviour
{
    public GameObject rulesImport;
    public GameObject rulesTextImport;
    public GameObject rulesText2Import;
    public GameObject backImport;
    public GameObject nextImport;
    public GameObject titleTextImport;
    public GameObject playButtonImport;
    public GameObject backButtonImport;
    public void Start()
    {
        rulesImport.SetActive(false);
        rulesTextImport.SetActive(false);
        rulesText2Import.SetActive(false);
        backImport.SetActive(false);
        nextImport.SetActive(false);
    }
    public void howToPlay()
    {
        titleTextImport.SetActive(false);
        gameObject.SetActive(false);
        playButtonImport.SetActive(false);
        rulesImport.SetActive(true);
        rulesTextImport.SetActive(true);
        backImport.SetActive(true);
        nextImport.SetActive(true);
    }
}
