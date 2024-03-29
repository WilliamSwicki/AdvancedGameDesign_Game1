using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleObjects : MonoBehaviour
{
    bool turnOnObject;
    bool turnOffObject;
    bool turnOffSelf;
    public GameObject effectedObject;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (turnOnObject)
            {
                effectedObject.SetActive(true);
            }
            else
            {
                effectedObject.SetActive(false);
            }
            if(turnOffObject)
            {
                effectedObject.GetComponent<Collider2D>().enabled = false;
            }
            else
            {
                effectedObject.GetComponent<Collider2D>().enabled = true;
            }
            if(turnOffSelf)
            {
                this.GetComponent<Collider2D>().enabled=false;
            }
        }
    }
}
