using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float moveSpeed = 10;
    public float moveSpeedr = 0.1f;
    private Animator animator;
    private Vector3 direction;
    private Vector3 t;
    private Rigidbody rb;
    private AudioSource stepAudio;
   

    public Button restartButton;
    public Button quitButton;

    // public float playerAngleY;

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
        // playerAngleY = this.GameObject.transform.eulerAngles.y;
        //float moveH = Input.GetAxis("Horizontal");
        //float moveV = Input.GetAxis("Vertical");
      
        float vdep = Input.GetAxis("Vertical")* moveSpeed;
        float tourne = Input.GetAxis("Horizontal")*moveSpeedr;
        //rb.AddRelativeForce(0,0,vdep);
        //
        bool hasMoveH = !Mathf.Approximately(tourne,0);
        bool hasMoveV = !Mathf.Approximately(vdep,0);

        //bool Istourning = hasMoveH;
        

        bool IsWalking = hasMoveV|| hasMoveH;
        animator.SetBool("IsWalking", IsWalking);
        bool Istourning = hasMoveH;

        


        
      

        if(IsWalking)
        {

            direction = new Vector3(0, 0, vdep);
            direction = transform.TransformDirection (direction); 
            

            // direction = Quaternion.Euler(0, playerAngleY, 0) * direction;
            if (!stepAudio.isPlaying)
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
        int rotation =0 ; 
        if(Input.GetKey(KeyCode.RightArrow)){
            rotation = 2 ; 

        }
        //Debug.Log("rotation="+rotation);
        rb.isKinematic = true ; 
        transform.Rotate(0,rotation,0);
        rb.isKinematic = false  ; 

        
        if(Input.GetKey(KeyCode.LeftArrow)){
            rotation = -2 ; 

        }
        //Debug.Log("rotation="+rotation);
        rb.isKinematic = true ; 
        transform.Rotate(0,rotation,0);
        rb.isKinematic = false  ; 
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
        direction.Normalize();
        Vector3 deltaDirection = Vector3.RotateTowards(transform.forward, direction, Time.deltaTime * moveSpeed, 0);
        Quaternion rotation = Quaternion.LookRotation(direction);
        //rb.MoveRotation(rotation);
        rb.MovePosition(transform.position + direction * animator.deltaPosition.magnitude);
    }
}
