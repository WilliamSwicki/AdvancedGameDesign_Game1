using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PuzzleObjects : MonoBehaviour
{
    public bool turnOnObject;
    public bool turnOffColider;
    public bool turnOffSelf;
    public bool givenItem;
    public GameObject itemCard;
    public GameObject itemLocation;
    public GameObject effectedObject;
    public TMP_Text feedBack;
    public string feedBackText;
    
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
        if (Input.GetMouseButtonDown(0))
        {
            if (givenItem)
            {
                GivenItem();
            }
            if (turnOnObject)
            {
                TurnOnObject();
            }
            if (turnOffColider)
            {
                TurnOffColider();
            }
            if (turnOffSelf)
            {
                this.GetComponent<Collider2D>().enabled = false;
            }
            StartCoroutine(FeedbackText());
            
        }
    }
    private IEnumerator FeedbackText()
    {
        feedBack.text = feedBackText;
        yield return new WaitForSeconds(1);
        feedBack.text = "";
    }

    private void TurnOnObject()
    {
        if (!effectedObject.activeSelf)
        {
            effectedObject.SetActive(true);
        }
        else
        {
            effectedObject.SetActive(false);
        }
    }
    private void TurnOffColider()
    {
        if (effectedObject.GetComponent<Collider2D>().enabled == true)
        {
            effectedObject.GetComponent<Collider2D>().enabled = false;
        }
        else
        {
            effectedObject.GetComponent<Collider2D>().enabled = true;
        }
    }
    private void GivenItem()
    {
        Instantiate(itemCard, itemLocation.transform);
    }
}
