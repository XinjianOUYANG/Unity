using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public float speed = 5;
    public CanvasGroup indicationBackground;
    public CanvasGroup indicationQuestion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(30, 45, 90) * speed * Time.deltaTime);
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player OnTrigger");
        if(other.gameObject.CompareTag("Player"))
        {
            indicationBackground.gameObject.SetActive(true);
            indicationBackground.alpha = 0.9f;
        }
    }

    public void OnContinue()
    {
        Debug.Log("Indicator Continue");
        indicationBackground.gameObject.SetActive(false);
        indicationQuestion.gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
