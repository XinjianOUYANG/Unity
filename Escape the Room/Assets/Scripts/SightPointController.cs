using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SightPointController : MonoBehaviour
{
    private bool needDetect = false;
    public Transform playerTransform;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void Update()
    {
        if(needDetect)
        {
            Vector3 rayDirection = playerTransform.position - transform.position + Vector3.up;
            Ray ray = new Ray(transform.position, rayDirection);
            RaycastHit raycastHit;
            if(Physics.Raycast(ray,out raycastHit))
            {
                if(raycastHit.collider.transform == playerTransform)
                {
                    Debug.Log("Cat! I caught U !!! ");
                    gameManager.Fail();
                }
                else
                {
                    Debug.Log("Not a cat but " + raycastHit.collider);
                }
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("John Lemon is entering the fieled ! ");
            needDetect = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("John Lemon is leaving the fieled ! ");
            needDetect = false;
        }
    }

    // Update is called once per frame

}
