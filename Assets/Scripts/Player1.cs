using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : Paddle //Inherits from Paddle class
{

    float velocityConstant = 5.0f;//velocity of paddle every time a key is pressed
   
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            _rigidbody.velocity = new Vector2(0,velocityConstant);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _rigidbody.velocity = new Vector2(0, -velocityConstant);
        }
    }



    
}
