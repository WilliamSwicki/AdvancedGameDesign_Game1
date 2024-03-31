using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CodeWindow : MonoBehaviour
{
    public GameObject[] code;
    public int[] codeSol;
    public int correctNum;
    // Start is called before the first frame update
    void Start()
    {
        correctNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < code.Length; i++)
        {
            if (codeSol[i] == code[i].GetComponent<NumberCode>().currentValue)
            {
                correctNum++;
            }
            if (correctNum == code.Length)
            {
                SceneManager.LoadScene(2);
                //this.gameObject.SetActive(false);
            }
        }
        correctNum = 0;
    }
    
}
