using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{

   // Start is called before the first frame update
   public void OnRestart()
   {
      Debug.Log("OnRestart called"); 
      SceneManager.LoadScene("SampleScene");
   }

   // Update is called once per frame
   public void OnQuit()
   {
      Debug.Log("OnQuit called") ;
      Application.Quit();
   }

}
