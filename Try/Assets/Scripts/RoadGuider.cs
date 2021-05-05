using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGuider: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player OnTrigger");
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Guider");
            this.gameObject.SetActive(false);
        }
    }

}
