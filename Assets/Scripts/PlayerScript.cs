using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed = 5f; // The speed at which the player moves
    public Rigidbody2D rb; // The player's Rigidbody2D component
    Vector2 movement;
    public Animator animator;

    public GameObject PauseScreen;
    public bool paused = false;
    public bool invOpened = false;
    public bool canOpenInv = true;
    public bool canOpenPause = true;
    public bool fighting = false;

    public GameObject newItemsGrid;
    public GameObject inventory;
    public GameObject invSlotParent;
    public GameObject runesScreen;
    public GameObject inventoryScreen;
    public GameObject travelScreen;
    public GameObject journalScreen;
    //public GameObject fightMenu;



//FIGHTING----------------
        //detecting enemy
    public GameObject colEnemy;
    public Vector3 enemyScale;
    public Vector3 enemyMove;
    public Vector3 enemyPrevPos;
    public Collider2D enemyTriggerCol;
        //battling
    public int playerHP = 100;
    public Sprite activeWeapon;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component on start
        //newItemsGrid = GameObject.Find("newitemarea"); 
        //fightMenu = GameObject.Find("fightscene"); fightMenu.SetActive(false);
        runesScreen = GameObject.Find("Runes screen"); runesScreen.SetActive(false);
        inventoryScreen = GameObject.Find("Inventory screen"); inventoryScreen.SetActive(false);
        travelScreen = GameObject.Find("Travel Screen"); travelScreen.SetActive(false);
        journalScreen = GameObject.Find("Journal screen"); journalScreen.SetActive(false);
        inventory = GameObject.Find("Inventory shit"); invSlotParent = GameObject.Find("quick slots"); inventory.SetActive(false);     
        PauseScreen.SetActive(false);
    }

    void Update()
    {
        //Movement---------------------------------------------------------------------
        if(!paused && !fighting){
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");

            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("Speed", movement.sqrMagnitude);
        }

        //Get Keys--------------------------------------------------------------------
                    //pausing
        if(!paused && Input.GetKeyDown(KeyCode.Escape)){
            CancelAnimation();
            PauseScreen.SetActive(true);
            paused = true;
            inventoryScreen.SetActive(false);
            inventory.SetActive(false);  
        }
        else if(paused && Input.GetKeyDown(KeyCode.Escape)){
            paused = false;
            PauseScreen.SetActive(false);
        }
                    //inventory
        if(Input.GetKeyDown(KeyCode.E) && !invOpened){
            CancelAnimation();
            paused = true;
            invOpened = true;
            PauseScreen.SetActive(false);
            inventory.SetActive(true);
            inventoryScreen.SetActive(true);
        }
        else if((Input.GetKeyDown(KeyCode.E) && invOpened) || (Input.GetKeyDown(KeyCode.Escape) && invOpened)){
            invOpened = false;
            paused = false;
            inventoryScreen.SetActive(false);
            inventory.SetActive(false);
        }

    }

    void FixedUpdate()
    {
        // Move the player's Rigidbody2D component
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime); //rb.velocity = movement;
        //activeWeapon = invSlotParent.transform.GetChild(0).gameObject.transform;
    }

    public void CancelAnimation(){
        movement.x = 0;
        movement.y = 0;
        animator.SetFloat("Horizontal", 0);
        animator.SetFloat("Vertical", 0);
        animator.SetFloat("Speed", 0);
    }
}