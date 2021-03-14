using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public void playGame()
    {
        GameObject darkScreen = GameObject.Find("DarkScreen");
        DarkScreen script = darkScreen.GetComponent<DarkScreen>();
        script.active = true;
    }
}
