using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    public GameObject rulesImport;
    public GameObject rulesTextImport;
    public GameObject rulesText2Import;
    public GameObject nextImport;
    public GameObject titleTextImport;
    public GameObject playButtonImport;
    public GameObject howToPlayButtonImport;
    public void pressed()
    {
        titleTextImport.SetActive(true);
        playButtonImport.SetActive(true);
        howToPlayButtonImport.SetActive(true);

        gameObject.SetActive(false);
        rulesImport.SetActive(false);
        rulesTextImport.SetActive(false);
        rulesText2Import.SetActive(false);
        nextImport.SetActive(false);
    }
}
