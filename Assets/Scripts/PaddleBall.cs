using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleBall : MonoBehaviour
{
    public Rigidbody2D ball;
    float velocityX ;
    float velocityY ;
    float theta;
    public float vel = 8.0f;//velocity of ball when every round starts
    Vector2 currentVelocity;
    Vector2 velocityBeforeCollision;
    public GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody2D>();
        
        Ballreset();
        
     
    }

    // Update is called once per frame
    void Update()
    {
        currentVelocity = ball.velocity;
        
        
    }
    public void Initialvelocity()
    {
        Debug.Log("\nInside initial velocity\n");
        theta = Random.Range(-.78f, .78f);

        velocityX = Mathf.Cos(theta) * vel;
        velocityY = Mathf.Sin(theta) * vel;
        ball.velocity = new Vector2(velocityX, velocityY);
        print("\nVelocityX:" + velocityX);
        print("\nVelocityY:" + velocityY);

    }
    public void Ballreset()
    {
        
         ball.position = new Vector2(0, 0);//set ball to center of screen
         ball.velocity = new Vector2(0, 0);//set ball velocity to zero
         Invoke("Initialvelocity", 4);//Call the function after 4 secs. 
        
        
    }

    void FixedUpdate()  // runs every 0.02 seconds to store velocity value
    {
        velocityBeforeCollision = ball.velocity;
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "InvisibleLeftWall" || collision.gameObject.name == "InvisibleRightWall")
        {
            Debug.Log("\nleft right collision\n");
            Ballreset();
            
            /*
            if (gameManager.Player1Score ==3 || gameManager.Player2Score==3)
            {
                
                this.Ballfinal();
            }

            else
            {
                this.Ballreset();
            }*/

        }

        else if(collision.gameObject.name == "Player1" || collision.gameObject.name == "Player2")
        {
            
            print("\nvelocity" + ball.velocity);
            ball.velocity = Vector2.Reflect(velocityBeforeCollision, collision.contacts[0].normal);
            
        }

        else 
        {
            Debug.Log("top bottom collision");
            ball.velocity = Vector2.Reflect(velocityBeforeCollision, collision.contacts[0].normal);
            
        }


    }
    

}
