using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float moveSpeed = 10;
    private Animator animator;
    private Vector3 direction;
    private Rigidbody rb;
    private AudioSource stepAudio;

    public Button restartButton;
    public Button quitButton;
    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
        rb = this.GetComponent<Rigidbody>();
        stepAudio = this.GetComponent<AudioSource>();

        restartButton.gameObject.SetActive(false);
        quitButton.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");
        bool hasMoveH = !Mathf.Approximately(moveH,0);
        bool hasMoveV = !Mathf.Approximately(moveV,0);

        bool IsWalking = hasMoveH || hasMoveV;
        animator.SetBool("IsWalking", IsWalking);

        if(IsWalking)
        {
            direction = new Vector3(moveH, 0, moveV);
            direction.Normalize();
            if(!stepAudio.isPlaying)
            {
                stepAudio.Play();
            }
        }
        else 
        {
            if(stepAudio.isPlaying)
            {
                stepAudio.Stop();
            }
        }
    }

    //Update Mode = Normal
    // private void FixedUpdate()
    // {
    //     Quaternion rotation = Quaternion.LookRotation(direction);
    //     rb.MoveRotation(rotationwa);

    // }

    //Update Mode = Animate Physics
    private void OnAnimatorMove()
    {
        //smooth rotation
        Vector3 deltaDirection = Vector3.RotateTowards(transform.forward, direction, Time.deltaTime * moveSpeed, 0);
        Quaternion rotation = Quaternion.LookRotation(direction);
        rb.MoveRotation(rotation);
        rb.MovePosition(transform.position + direction * animator.deltaPosition.magnitude);
    }
}
