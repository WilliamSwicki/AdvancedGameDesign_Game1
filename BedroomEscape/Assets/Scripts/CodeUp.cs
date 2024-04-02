using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeUp : MonoBehaviour
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
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if(hit.collider != null)
            {
NumberCode.currentValue++;
            if (NumberCode.currentValue > 9)
            {
                NumberCode.currentValue = 0;
            }
            }
            
        }
    }
 
}
