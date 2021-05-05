using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseACharacter : MonoBehaviour
{
    public CanvasGroup chooseACharacter;
    public CanvasGroup leftWay;
    public CanvasGroup rightWay;

    // private bool IsNapoleon = false;
    // private bool IsNewton = false;
    // private string nameofCharacter;

    // public float duration = 1f;
    // private float passTime = 0;

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
            Debug.Log("Guider");
            showCanvas(chooseACharacter);
        }
    }

    public void ChooseNapoleon()
    {
        Debug.Log("Choose Napoleon");
        // IsNapoleon = true;
        chooseACharacter.alpha = 0f;
        showCanvas(leftWay);
        this.gameObject.SetActive(false);
    }

    public void ChooseNetwon()
    {
        Debug.Log("Choose Newton");
        // IsNewton = true;
        chooseACharacter.alpha = 0f;
        showCanvas(rightWay);
        this.gameObject.SetActive(false);
    }

    // public void ChooseCharacter(string name)
    // {
    //     nameofCharacter = name;
    // }

    private void showCanvas(CanvasGroup page)
    {
        page.alpha = 1f;
    }

}
