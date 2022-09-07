using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public GameObject playerObject;
    public TextMeshProUGUI timerObject;

    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.Find("Player");

        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float timeLeft = 15 - Time.time - startTime;

        if (timeLeft > 0)
        {
            string seconds = (timeLeft % 60).ToString("f1");
            timerObject.text = (seconds);
        }
        else
        {
            // Lets Player know that time has run out
            playerObject.SendMessage("NoMoreTime");
        }
    }
}
