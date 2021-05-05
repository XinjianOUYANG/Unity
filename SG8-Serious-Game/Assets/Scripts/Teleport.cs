using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = teleportTarget.transform.position + new Vector3(0.5f,0.5f,0) ;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
