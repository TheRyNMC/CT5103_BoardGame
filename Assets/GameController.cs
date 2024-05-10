using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameController : MonoBehaviour {
    [Header("Header References")]
    public Image playerXicon;
    public Image playerOicon;
    public TMP_InputField playerXInputField;
    public TMP_InputField playerOInputField;
    public TMP_Text winnerText;

    [Header("End + Options References")]
    public GameObject endGameState;

    [Header("Asset References")]
    public Sprite tilePlayerO;
    public Sprite tilePlayerX;
    public Sprite tileEmpty;
    public TMP_Text[] tileList;

    [Header("GameState Settings")]
    public Color inactivePlayerColor;
    public Color activePlayerColor;
    public string whoPlaysFirst;

    [Header("Variables")]
    private string playerTurn;
    private string playerXname;
    private string playerOname;
    private List<int> buttonsToDisable;

    private void Start() {
        playerTurn = whoPlaysFirst;
        if (playerTurn == "X")
        {
            playerOicon.color = inactivePlayerColor;
        }
        else {
            playerXicon.color = inactivePlayerColor;
        }

        //buttonsToDisable = new List<int> { 6, 7, 8, 11, 12, 13, 16, 17, 18 };

        //foreach (int index in buttonsToDisable) {
        //    tileList[index].GetComponentInParent<Button>().interactable = false;
        //}

        //playerXInputField.onValueChanged.AddListener(delegate { OnPlayerXNameChanged(); });
        //playerOInputField.onValueChanged.AddListener(delegate { OnPlayerONameChanged(); });

        //playerXname = playerXInputField.text;
        //playerOname = playerOInputField.text;

    }

    public void Update() {
        bool allTilesHaveText = true; // Initialize to true

        for (int i = 0; i < tileList.Length; i++) {
            TMP_Text buttonText = tileList[i].GetComponent<TMP_Text>();

            if (string.IsNullOrEmpty(buttonText.text)) {
                allTilesHaveText = false;
            }
            //if (!string.IsNullOrEmpty(buttonText.text)) {
            //    tileList[i].GetComponentInParent<Button>().interactable = false;
            //}
        }

        if (allTilesHaveText) {
            GameOver("D");
        }
    }

    //public void OnButtonClick0(){
    //    Button button20 = tileList[20].GetComponentInParent<Button>();
    //    Button button4 = tileList[4].GetComponentInParent<Button>();
    //    TMP_Text buttonText20 = tileList[20].GetComponent<TMP_Text>();
    //    TMP_Text buttonText4 = tileList[4].GetComponent<TMP_Text>();

    //    // Set buttons 20 and 4 interactable to true
    //    button20.interactable = true;
    //    button4.interactable = true;

    //    // Add onClick listener for button20 and button4
    //    button20.onClick.AddListener(SelectTile20);
    //    button4.onClick.AddListener(SelectTile4);

    //    // Loop through the tileList to disable all other buttons
    //    foreach (var tile in tileList)
    //    {
    //        Button button = tile.GetComponentInParent<Button>();
    //        if (button != button20 && button != button4)
    //        {
    //            button.interactable = false;
    //        }
    //    }
    //}

    //public void OnButtonClick1()
    //{
    //    Button button21 = tileList[21].GetComponentInParent<Button>();
    //    TMP_Text buttonText21 = tileList[21].GetComponent<TMP_Text>();
    //    Button button4 = tileList[4].GetComponentInParent<Button>();
    //    TMP_Text buttonText4 = tileList[4].GetComponent<TMP_Text>();
    //    Button button0 = tileList[0].GetComponentInParent<Button>();
    //    TMP_Text buttonText0 = tileList[0].GetComponent<TMP_Text>();

    //    // Set buttons 20 and 4 interactable to true
    //    button21.interactable = true;
    //    button4.interactable = true;
    //    button0.interactable = true;

    //    // Add onClick listener for button20 and button4
    //    button21.onClick.AddListener(SelectTile21);
    //    button4.onClick.AddListener(SelectTile4);
    //    button0.onClick.AddListener(SelectTile0);

    //    // Loop through the tileList to disable all other buttons
    //    foreach (var tile in tileList)
    //    {
    //        Button button = tile.GetComponentInParent<Button>();
    //        if (button != button21 && button != button4 && button != button0)
    //        {
    //            button.interactable = false;
    //        }
    //    }
    //}

    //public void SelectTile0(){
    //    Button button0 = tileList[0].GetComponentInParent<Button>();
    //    TMP_Text button0Text = tileList[0].GetComponent<TMP_Text>();

    //    // Enable all buttons and disable specified buttons
    //    EnableAllButtons();
    //    DisableButtons();

    //    // Update text and sprite of button20
    //    UpdateButton(button0, button0Text);
    //}

    //public void SelectTile21() {
    //    Button button21 = tileList[21].GetComponentInParent<Button>();
    //    TMP_Text button21Text = tileList[21].GetComponent<TMP_Text>();

    //    // Enable all buttons and disable specified buttons
    //    EnableAllButtons();
    //    DisableButtons();

    //    // Update text and sprite of button20
    //    UpdateButton(button21, button21Text);
    //}

    //public void SelectTile20() {
    //    Button button20 = tileList[20].GetComponentInParent<Button>();
    //    TMP_Text button20Text = tileList[20].GetComponent<TMP_Text>();

    //    // Enable all buttons and disable specified buttons
    //    EnableAllButtons();
    //    DisableButtons();

    //    // Update text and sprite of button20
    //    UpdateButton(button20, button20Text);
    //}

    //public void SelectTile4()
    //{
    //    Button button4 = tileList[4].GetComponentInParent<Button>();
    //    TMP_Text button4Text = tileList[4].GetComponent<TMP_Text>();

    //    // Enable all buttons and disable specified buttons
    //    EnableAllButtons();
    //    DisableButtons();

    //    // Update text and sprite of button4
    //    UpdateButton(button4, button4Text);
    //}

    //private void EnableAllButtons()
    //{
    //    foreach (var tile in tileList)
    //    {
    //        tile.GetComponentInParent<Button>().interactable = true;
    //    }
    //}

    //private void DisableButtons()
    //{
    //    foreach (int index in buttonsToDisable)
    //    {
    //        tileList[index].GetComponentInParent<Button>().interactable = false;
    //    }
    //}

    //private void UpdateButton(Button button, TMP_Text buttonText){
    //    buttonText.text = GetPlayersTurn();
    //    button.image.sprite = GetPlayerSprite();
    //    button.interactable = false;
    //    ChangeTurn();
    //}


    public void OnPlayerXNameChanged() {
        playerXname = playerXInputField.text;
    }

    public void OnPlayerONameChanged() {
        playerOname = playerOInputField.text;
    }


    /// <summary>
    /// Tiles are numbered 0..24 from left to right, row by row, example:
    /// [0] [1] [2] [3] [4]
    /// [5] [6] [7] [8] [9]
    /// [10][11][12][13][14]
    /// [15][16][17][18][19]
    /// [20][21][22][23][24]
    /// </summary>

    public void EndTurn() {
        if (tileList[0].text == playerTurn && tileList[1].text == playerTurn && tileList[2].text == playerTurn && tileList[3].text == playerTurn && tileList[4].text == playerTurn) GameOver(playerTurn);
        else if (tileList[5].text == playerTurn && tileList[6].text == playerTurn && tileList[7].text == playerTurn && tileList[8].text == playerTurn && tileList[9].text == playerTurn) GameOver(playerTurn);
        else if (tileList[10].text == playerTurn && tileList[11].text == playerTurn && tileList[12].text == playerTurn && tileList[13].text == playerTurn && tileList[14].text == playerTurn) GameOver(playerTurn);
        else if (tileList[15].text == playerTurn && tileList[16].text == playerTurn && tileList[17].text == playerTurn && tileList[18].text == playerTurn && tileList[19].text == playerTurn) GameOver(playerTurn);
        else if (tileList[20].text == playerTurn && tileList[21].text == playerTurn && tileList[22].text == playerTurn && tileList[23].text == playerTurn && tileList[24].text == playerTurn) GameOver(playerTurn);
        else if (tileList[0].text == playerTurn && tileList[5].text == playerTurn && tileList[10].text == playerTurn && tileList[15].text == playerTurn && tileList[20].text == playerTurn) GameOver(playerTurn);
        else if (tileList[1].text == playerTurn && tileList[6].text == playerTurn && tileList[11].text == playerTurn && tileList[16].text == playerTurn && tileList[21].text == playerTurn) GameOver(playerTurn);
        else if (tileList[2].text == playerTurn && tileList[7].text == playerTurn && tileList[12].text == playerTurn && tileList[17].text == playerTurn && tileList[22].text == playerTurn) GameOver(playerTurn);
        else if (tileList[3].text == playerTurn && tileList[8].text == playerTurn && tileList[13].text == playerTurn && tileList[18].text == playerTurn && tileList[23].text == playerTurn) GameOver(playerTurn);
        else if (tileList[4].text == playerTurn && tileList[9].text == playerTurn && tileList[14].text == playerTurn && tileList[19].text == playerTurn && tileList[24].text == playerTurn) GameOver(playerTurn);
        else if (tileList[0].text == playerTurn && tileList[6].text == playerTurn && tileList[12].text == playerTurn && tileList[18].text == playerTurn && tileList[24].text == playerTurn) GameOver(playerTurn);
        else if (tileList[4].text == playerTurn && tileList[8].text == playerTurn && tileList[12].text == playerTurn && tileList[16].text == playerTurn && tileList[20].text == playerTurn) GameOver(playerTurn);
        else
            ChangeTurn();
    }

    public void ChangeTurn()
    {
        playerTurn = (playerTurn == "X") ? "O" : "X";

        // Adjust player icon colors based on the current player's turn
        if (playerTurn == "X")
        {
            playerXicon.color = activePlayerColor;
            playerOicon.color = inactivePlayerColor;
        }
        else
        {
            playerXicon.color = inactivePlayerColor;
            playerOicon.color = activePlayerColor;
        }
    }

    private void GameOver(string winningPlayer) {
    switch (winningPlayer) {
        case "X":
            winnerText.text = playerXname + " wins!!!";
            break;
        case "O":
            winnerText.text = playerOname + " wins!!!";
            break;
        case "D":
            winnerText.text = "DRAW";
            break;
        }
    endGameState.SetActive(true);
    ToggleButtonState(false);
    }

    private void ToggleButtonState(bool state) {
        for (int i = 0; i < tileList.Length; i++) {
            tileList[i].GetComponentInParent<Button>().interactable = state;
        }
    }

    public string GetPlayersTurn() {
        return playerTurn;
    }

    public Sprite GetPlayerSprite() {
        if (playerTurn == "X") return tilePlayerX;
        else return tilePlayerO;
    }

}

