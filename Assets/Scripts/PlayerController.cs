using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float fltorqueAmount = 1f;
    [SerializeField] float BoosterSpeed = 8f;
    [SerializeField] float NormalSpeed = 5f;
    Rigidbody2D rigidBody2D;
    SurfaceEffector2D surfaceEffector2D;
    bool blAllowMove = true;
    // Start is called before the first frame update
    void Start()
    {
       rigidBody2D = GetComponent<Rigidbody2D>(); 
       surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (blAllowMove)
        {
        RotatePlayer();
        ResponseToBoost();
        }
        

    }
    
    public void MoveDenied()
    {
        blAllowMove = false;
    }
    void ResponseToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = BoosterSpeed;
        }

        else
        {
            surfaceEffector2D.speed = NormalSpeed;
        }
    }    
        
    private void RotatePlayer()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rigidBody2D.AddTorque(fltorqueAmount);
        }

        else if(Input.GetKey(KeyCode.RightArrow))
        {
            rigidBody2D.AddTorque(-fltorqueAmount);
        }
    }
        

    
}
