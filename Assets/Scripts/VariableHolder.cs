using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class VariableHolder : MonoBehaviour
{
    public GameObject newItemsGrid;
    public GameObject inventory;
    public GameObject invSlotParent;
    public GameObject runesScreen;
    public GameObject inventoryScreen;
    public GameObject travelScreen;
    public GameObject journalScreen;
    public GameObject newItemsArea;
    public GameObject hotBar;
    public GameObject effectsTextHolder;
    public GameObject runeSmithScreen;
    public TMP_Text goldText;
    public GameObject pauseMenu;
    int gottenPausel = 0;
    public List<GameObject> anyItem = new List<GameObject>();

    /*
    runesScreen = GameObject.Find("Runes screen"); runesScreen.SetActive(false);
    inventoryScreen = GameObject.Find("Inventory screen"); inventoryScreen.SetActive(false);
    travelScreen = GameObject.Find("Travel Screen"); travelScreen.SetActive(false);
    journalScreen = GameObject.Find("Journal screen"); journalScreen.SetActive(false);
    inventory = GameObject.Find("Inventory shit"); invSlotParent = GameObject.Find("quick slots"); inventory.SetActive(false);
    */

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(SceneManager.GetActiveScene().name == "Ms G Test"){
            if(gottenPausel == 0){
                pauseMenu = GameObject.Find("OverworldMC").GetComponent<PlayerScript>().PauseScreen;
                gottenPausel = 1;
            }
        }
    }
}
