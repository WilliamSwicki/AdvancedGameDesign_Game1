using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LeaveScript : MonoBehaviour
{
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
            StartCoroutine(Leave());
        }
    }
    private IEnumerator Leave()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(2);
    }
}
