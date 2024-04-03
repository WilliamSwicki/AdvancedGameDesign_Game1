using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WakeUp : MonoBehaviour
{
    public TMP_Text feedBack;
    public GameObject timer;
    public GameObject backGround;
    // Start is called before the first frame update
    void Start()
    {
        feedBack.text = "Where Am I?  It's so dark and gloomy.";
        timer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CallForHelp()
    {
        feedBack.text = "I hear something coming and it dosnt sound frendly";
        timer.GetComponent<Timer>().time = 30;
        StartCoroutine(FeedbackText());
        backGround.SetActive(false);
        timer.SetActive(true);
    }
    public void LookAround()
    {
        feedBack.text = "I guess I have to find a way to get out";
        timer.GetComponent<Timer>().time = 60;
        StartCoroutine(FeedbackText());
        backGround.SetActive(false);
        timer.SetActive(true);
    }
    private IEnumerator FeedbackText()
    {
        yield return new WaitForSeconds(1);
        feedBack.text = "";
    }
}
