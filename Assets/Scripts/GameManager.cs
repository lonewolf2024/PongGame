using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    public int Player1Score = 0;
    public int Player2Score = 0;
    public TMPro.TMP_Text Player1text;
    public TMPro.TMP_Text Player2text;
    public TMPro.TMP_Text WinText;
    

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public void updatePlayer1Score()
    {
 
        Player1Score = Player1Score + 1;
        this.Player1text.text = Player1Score.ToString();
        CheckWinner();
        

    }
    public void updatePlayer2Score()
    {
     
        Player2Score = Player2Score + 1;
        this.Player2text.text = Player2Score.ToString();
        CheckWinner();


    }

    public void CheckWinner()
    {
        ;
        if (Player1Score == 3) 
        { 
            this.WinText.text = "Player1 Wins!";

            Invoke("LoadNewScene", 2);
            
        }
        if (Player2Score == 3) 
        {
            
            this.WinText.text = "Player2 Wins!";
            Invoke("LoadNewScene", 2);
            
        }


    }
    void LoadNewScene()
    {
        SceneManager.LoadScene("GameOverScene");
    }
}
