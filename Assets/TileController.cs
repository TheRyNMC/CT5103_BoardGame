using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class TileController : MonoBehaviour {
    
    [Header("References")]
    public GameController GameController;                       
    public Button Button;
    public TMP_Text Text;

    public void UpateTile() {
        Text.text = GameController.GetPlayersTurn();
        Button.image.sprite = GameController.GetPlayerSprite();
        Button.interactable = false;

        GameController.EndTurn();
    }

    //public void OnBC0(){
    //    GameController.OnButtonClick0();
    //    Button.interactable = false;
    //}

    //public void OnBC1() {
    //    GameController.OnButtonClick1();
    //    Button.interactable = false;
    //}

    public void ResetTile() {
        Text.text = "";
        Button.image.sprite = GameController.tileEmpty;
    }

}