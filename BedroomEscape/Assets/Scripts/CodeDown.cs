using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeDown : MonoBehaviour
{
    public NumberCode NumberCode;
    // Start is called before the first frame update
    void Start()
    {
        NumberCode = transform.parent.GetComponent<NumberCode>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseOver()
    {

        if (Input.GetMouseButtonDown(0))
        {
            NumberCode.currentValue--;
            if (NumberCode.currentValue < 0)
            {
                NumberCode.currentValue = 9;
            }
        }
    }
}
