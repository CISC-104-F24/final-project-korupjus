using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class PlayerUI : MonoBehaviour
{
    public float playerMoney; //1 point
    public string playerMoneyText; //1 point
    public float roundNumber; // 1 point
    public string roundNumberText; //1 point
    public TextMeshProUGUI playerMoneyUI; //1 point
    public TextMeshProUGUI squareButtonUI; // 1point
    public TextMeshProUGUI circleButtonUI; // 1 point
    public TextMeshProUGUI triangleButtonUI; // 1 point
    public TextMeshProUGUI roundNumberUI; // 1 point
    public GameObject startButton; // 1 point
    public GameObject roundStartButton; //1point
    // Start is called before the first frame update
    void Start()
    {
        roundStartButton.SetActive(false);   

    }

    // Update is called once per frame
    void Update()
    {
        playerMoneyText = "Money: $" + playerMoney;
        playerMoneyUI.text = playerMoneyText;
        roundNumberText = "Round:" + roundNumber + "/10";
        roundNumberUI.text = roundNumberText;
        squareButtonUI.color = Color.green;
        circleButtonUI.color = Color.green;
        triangleButtonUI.color = Color.green;
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
        roundNumberText = roundNumberUI.text;
    }
}
