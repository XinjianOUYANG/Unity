using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    public Text scoreText;
    public Text winText;

    public Button restartButton;
    public Button quitButton;

    private float moveH = 0;
    private float moveV = 0;
    private int score = 0;

    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
        winText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        quitButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        moveH = Input.GetAxis("Horizontal");
        moveV = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(moveH, 0, moveV);
        rigidbody.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player OnTrigger");
        if(other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            score = score + 1;
            scoreText.text = "Score: " + score.ToString();
            if(score == 4)
            {
                winText.gameObject.SetActive(true);
                restartButton.gameObject.SetActive(true);
                quitButton.gameObject.SetActive(true);
            }
        }
    }
}
