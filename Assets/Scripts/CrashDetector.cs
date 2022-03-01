using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float LoadingDelay = 1f;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ground")
        {
            Debug.Log("Shit! I am dead!");
            Invoke("ReloadScene",LoadingDelay);
        }
    }

     void ReloadScene()
   {
       SceneManager.LoadScene(0);
   }
}
