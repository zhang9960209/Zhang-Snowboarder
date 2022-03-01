using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float fltorqueAmount = 1f;
    Rigidbody2D rigidBody2D;
    // Start is called before the first frame update
    void Start()
    {
       rigidBody2D = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
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
