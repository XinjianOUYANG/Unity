using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform target;
    [SerializeField] Transform character;
    Vector3 offsetCamera;
    void Start()
    {
        offsetCamera = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPosition = target.position + offsetCamera ;
        transform.position = cameraPosition ;
        //Vector3 to=character.transform.position - target.transform.position;

        //transform.rotation= Quaternion.Slerp(transform.rotation,Quaternion.LookRotation(to), 1);
    }
}
