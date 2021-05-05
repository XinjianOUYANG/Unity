using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomeGuider : MonoBehaviour
{
    public CanvasGroup welcomePage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player OnTrigger");
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Welcome");
            welcomePage.gameObject.SetActive(true);
            welcomePage.alpha = 0.9f;             
        }
    }

    public void Continue()
    {
        Debug.Log("Welcome Continue");
        welcomePage.gameObject.SetActive(false); 
        this.gameObject.SetActive(false);
    }

}
