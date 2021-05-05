using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitDoorController : MonoBehaviour
{
    public Button restartButton;
    public Button quitButton;

    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"));
        {
            Debug.Log("Player exit the room suc !!");
            restartButton.gameObject.SetActive(true);
            quitButton.gameObject.SetActive(true);
            gameManager.Win();
        }
    }
}
