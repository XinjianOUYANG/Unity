using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Camera follow
public class CameraController : MonoBehaviour
{
    public Transform player;

    public float distanceUp = 2f;
    public float distanceAway = 1f;
    public float smooth = 2f;
    
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = player.position - this.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // this.transform.position = player.position - offset;

        // the position of the camera
        Vector3 disPos = player.position + Vector3.up * distanceUp - player.forward * distanceAway - offset;
        transform.position=Vector3.Lerp(transform.position,disPos,Time.deltaTime*smooth);
        //the angle of the camera
        transform.LookAt(player.position);
        
    }
}
