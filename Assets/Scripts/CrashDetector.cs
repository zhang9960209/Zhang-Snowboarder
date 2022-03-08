using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float LoadingDelay = 1f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip CrashSFX;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ground")
        {
            FindObjectOfType<PlayerController>().MoveDenied();
            Debug.Log("Shit! I am dead!");
            GetComponent<AudioSource>().PlayOneShot(CrashSFX);
            Invoke("ReloadScene",LoadingDelay);
            crashEffect.Play();
        }
    }

    void ReloadScene()
    {
       SceneManager.LoadScene(0);
    }
}
