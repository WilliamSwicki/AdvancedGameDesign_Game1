using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumberCode : MonoBehaviour
{
    public int currentValue;
    public TMP_Text numberValue;

    // Start is called before the first frame update
    void Start()
    {
        currentValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        numberValue.text = currentValue.ToString();

    }
}
