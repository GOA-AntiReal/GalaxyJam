using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton : MonoBehaviour
{
    public GameObject rulesTextImport;
    public GameObject rulesText2Import;
    public void pressed()
    {
        rulesText2Import.SetActive(true);

        gameObject.SetActive(false);
        rulesTextImport.SetActive(false);
    }
}
