using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseACharacter : MonoBehaviour
{
    // private CanvasGroup chooseACharacter;
    public GameObject Napoleon;
    // Start is called before the first frame update
    void Start()
    {
        Napoleon.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChooseNapoleon()
   {
        Debug.Log("OnChoose called"); 
        Napoleon.gameObject.SetActive(true);
        this.gameObject.SetActive(false);
   }
}
