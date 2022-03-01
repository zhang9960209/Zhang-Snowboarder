using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
   [SerializeField] float LoadingDelay = 1f;
   
   void OnTriggerEnter2D(Collider2D other) 
   {
       if (other.tag == "Player")
       {
           Debug.Log("You Finished!");
           Invoke("ReloadScene",LoadingDelay);
       } 
       
   }
   void ReloadScene()
   {
       SceneManager.LoadScene(0);
   }
}
