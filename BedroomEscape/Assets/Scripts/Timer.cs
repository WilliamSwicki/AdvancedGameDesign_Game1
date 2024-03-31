using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float time;
    public float screenChangeTime;
    public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(time>0)
        {
            time = time - Time.deltaTime;
            text.text = "Time left: " + Mathf.Round(time);
        }
        else
        {
            StartCoroutine(TimesUp());
        }
    }
    private IEnumerator TimesUp()
    {
        yield return new WaitForSeconds(screenChangeTime);
        SceneManager.LoadScene(4);
    }
}
