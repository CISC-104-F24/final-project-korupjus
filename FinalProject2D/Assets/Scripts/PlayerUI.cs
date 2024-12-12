using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class PlayerUI : MonoBehaviour
{
    public static float playerMoney; //1 point
    public string playerMoneyText;
    public static float playerLives;
    public string playerLivesText;
    public float roundNumber; // 1 point
    public string roundNumberText; //1 point
    public int numberEnemyOneSpawned;
    public int numberEnemyTwoSpawned;
    public int numberEnemyThreeSpawned;
    public TextMeshProUGUI playerMoneyUI; //1 point
    public TextMeshProUGUI squareButtonUI; // 1point
    public TextMeshProUGUI circleButtonUI; // 1 point
    public TextMeshProUGUI triangleButtonUI; // 1 point
    public TextMeshProUGUI roundNumberUI;// 1 point
    public TextMeshProUGUI playerLivesUI;
    public GameObject startButton; // 1 point
    public GameObject roundStartButton; //1point
    public GameObject circleTower;
    public GameObject squareTower;
    public GameObject triangleTower;
    public GameObject enemyOne;
    public GameObject enemyTwo;
    public GameObject enemyThree;
    
    // Start is called before the first frame update
    void Start()
    {
        roundStartButton.SetActive(false);
        playerLives = 100;
        playerMoney = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        playerLivesText= "Lives: " + playerLives;
        playerLivesUI.text = playerLivesText;
        playerMoneyText = "Money: $" + playerMoney;
        playerMoneyUI.text = playerMoneyText;
        roundNumberText = "Round:" + roundNumber + "/10";
        roundNumberUI.text = roundNumberText;
        if (playerMoney >= 300)
        {
            triangleButtonUI.color = Color.green;
        }
        else
        {
            triangleButtonUI.color = Color.gray;
        }
        if (playerMoney >= 500) 
        {
            squareButtonUI.color = Color.green;
        }
        else
        {
            squareButtonUI.color = Color.gray;
        }
        if (playerMoney >= 700) 
        { 
            circleButtonUI.color = Color.green; 
        }
        else
        {
            circleButtonUI.color = Color.gray;
        }
        if(roundNumber == 1 && numberEnemyOneSpawned == 10)
        {
            CancelInvoke("SpawnEnemyOne");
            if (numberEnemyOneSpawned == 10)
            {
                numberEnemyOneSpawned = 0;
            }
        }
        if (roundNumber == 2 && numberEnemyOneSpawned == 18)
        {
            CancelInvoke("SpawnEnemyOne");
            if (numberEnemyOneSpawned == 18)
            {
                numberEnemyOneSpawned = 0;
            }
        }
        if (roundNumber == 3 && numberEnemyOneSpawned == 7)
        {
            CancelInvoke("SpawnEnemyOne");
            if (numberEnemyOneSpawned == 7)
            {
                numberEnemyOneSpawned = 0;
            }
        }
        if (roundNumber == 3 && numberEnemyTwoSpawned == 9)
        {
            CancelInvoke("SpawnEnemyTwo");
            if (numberEnemyTwoSpawned == 9)
            {
                numberEnemyTwoSpawned = 0;
            }
        }
        if (roundNumber == 4 && numberEnemyTwoSpawned == 15)
        {
            CancelInvoke("SpawnEnemyTwo");
            if (numberEnemyTwoSpawned == 15)
            {
                numberEnemyTwoSpawned = 0;
            }
        }
        if (roundNumber == 5 && numberEnemyThreeSpawned == 13)
        {
            CancelInvoke("SpawnEnemyThree");
            if (numberEnemyThreeSpawned == 13)
            {
                numberEnemyThreeSpawned = 0;
            }
        }
        if (roundNumber == 6 && numberEnemyTwoSpawned == 10)
        {
            CancelInvoke("SpawnEnemyTwo");
            if(numberEnemyTwoSpawned == 10)
            {
                numberEnemyTwoSpawned = 0;
            }
        }
        if (roundNumber ==6 && numberEnemyThreeSpawned == 10)
        {
            CancelInvoke("SpawnEnemyThree");
            if( numberEnemyThreeSpawned == 10)
            {
                numberEnemyThreeSpawned = 0;
            }
        }
        if (roundNumber == 7 && numberEnemyThreeSpawned == 19)
        {
            CancelInvoke("SpawnEnemyThree");
            if (numberEnemyThreeSpawned == 19)
            {
                numberEnemyThreeSpawned = 0;
            }
        }
        if (roundNumber == 8 && numberEnemyTwoSpawned == 32)
        {
            CancelInvoke("SpawnEnemyTwo");
            if (numberEnemyTwoSpawned == 32)
            {
                numberEnemyTwoSpawned = 0;
            }
        }
        if (roundNumber == 9 && numberEnemyTwoSpawned == 15)
        {
            CancelInvoke("SpawnEnemyTwo");
            if (numberEnemyTwoSpawned == 15)
            {
                numberEnemyTwoSpawned = 0;
            }
        }
        if (roundNumber == 9 && numberEnemyThreeSpawned == 15)
        {
            CancelInvoke("SpawnEnemyThree");
            if (numberEnemyThreeSpawned == 15)
            {
                numberEnemyThreeSpawned = 0;
            }
        }
        if (roundNumber == 10 && numberEnemyOneSpawned == 10) 
        {
            CancelInvoke("SpawnEnemyOne");
            if(numberEnemyOneSpawned == 10)
            {
                numberEnemyOneSpawned = 0;
            }
        }
        if (roundNumber == 10 && numberEnemyTwoSpawned == 10)
        {
            CancelInvoke("SpawnEnemyTwo");
            if( numberEnemyTwoSpawned == 10)
            {
                numberEnemyTwoSpawned = 0;
            }
        }
        if (roundNumber == 10 && numberEnemyThreeSpawned == 20)
        {
            CancelInvoke("SpawnEnemyThree");
            if(numberEnemyThreeSpawned == 20)
            {
                numberEnemyThreeSpawned = 0;
            }
        }
        if (playerLives == 0)
        {
            SceneManager.LoadScene(1);
        }


    }
    public void OpenMenu()
    {
        SceneManager.LoadScene(1);
    }
    public void BuySquare(int SquareCost)
    {
        bool canBuySquare = false;
        canBuySquare = playerMoney >= SquareCost;
        if (canBuySquare)
        {
            //Debug.Log("square working");
            Instantiate(squareTower, squareTower.transform);
            playerMoney = playerMoney - SquareCost;
        }
        playerMoneyUI.text = playerMoneyText;
        
    }
    public void BuyCircle(int CircleCost)
    {
        bool canBuyCircle = false;
        canBuyCircle = playerMoney >= CircleCost;
        if (canBuyCircle)
        {
            //Debug.Log(" cicle working");
            Instantiate(circleTower, circleTower.transform);
            playerMoney = playerMoney - CircleCost;    
        }
        playerMoneyUI.text = playerMoneyText;
        
    }
    public void BuyTriangle(int TriangleCost)
    {
        bool canBuyTriangle = false;
        canBuyTriangle = playerMoney >= TriangleCost;
        if (canBuyTriangle)
        {

            //Debug.Log("triangle working"); 
            Instantiate(triangleTower, triangleTower.transform);
            playerMoney = playerMoney - TriangleCost;
        }
        playerMoneyUI.text = playerMoneyText;
        
    }
    public void StartGame()
    {
        startButton.SetActive(false);
        roundStartButton.SetActive(true);
    }
    public void RoundStart(int Round)
    {
        
        roundNumber = roundNumber + Round;
        if (roundNumber > 11)
        {
            roundNumber = 11;
        }
        roundNumberText = roundNumberUI.text;
        if(roundNumber == 1) // 10 difficulty
        {
            InvokeRepeating("SpawnEnemyOne", 1f, 1f);   
        }
        if (roundNumber == 2) // 18 difficulty
        {
            InvokeRepeating("SpawnEnemyOne", 1f, 0.75f);
            
        }
        if (roundNumber == 3) // 25 difficulty
        {
            InvokeRepeating("SpawnEnemyOne", 1f, 1f);
            InvokeRepeating("SpawnEnemyTwo", 2f, 0.7f);
            
        }
        if (roundNumber == 4) // 30 difficulty
        {
            InvokeRepeating("SpawnEnemyTwo", 1f, .5f);
        }
        if (roundNumber == 5) // 39 difficulty
        {
            InvokeRepeating("SpawnEnemyThree", 1f, 1.3f); 
        }
        if (roundNumber == 6) // 50 difficulty
        {
            InvokeRepeating("SpawnEnemyTwo", 1f, .9f);
            InvokeRepeating("SpawnEnemyThree", 1.5f, .9f);
        }
        if (roundNumber == 7) // 57 difficulty
        {
            InvokeRepeating("SpawnEnemyThree", 1f, .7f);
        }
        if (roundNumber == 8) // 64 difficulty
        {
            InvokeRepeating("SpawnEnemyTwo", 1f, .4f);  
        }
        if (roundNumber == 9) // 75 difficulty
        {
            
            InvokeRepeating("SpawnEnemyTwo", 1f, .7f);
            InvokeRepeating("SpawnEnemyThree", 5f, .2f);
        }
        if (roundNumber == 10) // 90 difficulty
        {
                InvokeRepeating("SpawnEnemyOne", 4f, .5f);
                InvokeRepeating("SpawnEnemyTwo", 4f, .5f);
                InvokeRepeating("SpawnEnemyThree", .5f, .33f);
        }
        if(roundNumber == 11)
        {
            SceneManager.LoadScene(1);
        }
    }
    public void SpawnEnemyOne()
    {
        Instantiate(enemyOne);
        numberEnemyOneSpawned += 1;
        //Debug.Log(numberEnemyOneSpawned);
    }
    public void SpawnEnemyTwo()
    {
        Instantiate(enemyTwo);
        numberEnemyTwoSpawned += 1;
    }
    public void SpawnEnemyThree()
    {
        Instantiate(enemyThree);
        numberEnemyThreeSpawned += 1;
    }

}
