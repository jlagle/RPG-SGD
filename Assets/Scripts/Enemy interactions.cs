using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyinteractions : MonoBehaviour
{
    public GameObject FightMenu;
    public string enemytype;
    public int eneymhp;
    public int enemydmg;
    public GameObject player;
    public GameObject enemyObj;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("OverworldMC");
        FightMenu = GameObject.Find("fighting sex");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            if(enemytype == "fireworm")
            {
                enemyObj = this.gameObject;
                Debug.Log(enemytype);
                /*
                player.GetComponent<PlayerScript>().colEnemy = enemyObj;
                player.GetComponent<PlayerScript>().fighting = true;
                player.GetComponent<PlayerScript>().CancelAnimation();
                FightMenu.GetComponent<FightingFunctions>().StartFight();
                player.GetComponent<PlayerScript>().enemyScale = new Vector3(1.93f, 1.93f, 1.93f);
                player.GetComponent<PlayerScript>().enemyMove = new Vector3(-1980, -761, 0);
                player.GetComponent<PlayerScript>().enemyPrevPos = transform.position;
                Debug.Log("hi ;3");
                */

            }
            if(enemytype == "monk")
            {
                enemyObj = this.gameObject;
                Debug.Log(enemytype);
                /*
                player.GetComponent<PlayerScript>().colEnemy = enemyObj;
                player.GetComponent<PlayerScript>().fighting = true;
                player.GetComponent<PlayerScript>().CancelAnimation();
                FightMenu.GetComponent<FightingFunctions>().StartFight();
                player.GetComponent<PlayerScript>().enemyScale = new Vector3(1.93f, 1.93f, 1.93f);
                player.GetComponent<PlayerScript>().enemyMove = new Vector3(-1980, -761, 0);
                player.GetComponent<PlayerScript>().enemyPrevPos = transform.position;
                Debug.Log("hi ;3");
                */
            }
            if (enemytype == "icegiant")
            {
                enemyObj = this.gameObject;
                Debug.Log(enemytype);
                /*
                player.GetComponent<PlayerScript>().colEnemy = enemyObj;
                player.GetComponent<PlayerScript>().fighting = true;
                player.GetComponent<PlayerScript>().CancelAnimation();
                FightMenu.GetComponent<FightingFunctions>().StartFight();
                player.GetComponent<PlayerScript>().enemyScale = new Vector3(1.93f, 1.93f, 1.93f);
                player.GetComponent<PlayerScript>().enemyMove = new Vector3(-1980, -761, 0);
                player.GetComponent<PlayerScript>().enemyPrevPos = transform.position;
                Debug.Log("hi ;3");
                */
            }
            if (enemytype == "joebid")
            {
                enemyObj = this.gameObject;
                Debug.Log(enemytype);
                /*
                player.GetComponent<PlayerScript>().colEnemy = enemyObj;
                player.GetComponent<PlayerScript>().fighting = true;
                player.GetComponent<PlayerScript>().CancelAnimation();
                FightMenu.GetComponent<FightingFunctions>().StartFight();
                player.GetComponent<PlayerScript>().enemyScale = new Vector3(1.93f, 1.93f, 1.93f);
                player.GetComponent<PlayerScript>().enemyMove = new Vector3(-1980, -761, 0);
                player.GetComponent<PlayerScript>().enemyPrevPos = transform.position;
                Debug.Log("hi ;3");
                */
            }
            if (enemytype == "joeyen")
            {
                enemyObj = this.gameObject;
                Debug.Log(enemytype);
                /*
                player.GetComponent<PlayerScript>().colEnemy = enemyObj;
                player.GetComponent<PlayerScript>().fighting = true;
                player.GetComponent<PlayerScript>().CancelAnimation();
                FightMenu.GetComponent<FightingFunctions>().StartFight();
                player.GetComponent<PlayerScript>().enemyScale = new Vector3(1.93f, 1.93f, 1.93f);
                player.GetComponent<PlayerScript>().enemyMove = new Vector3(-1980, -761, 0);
                player.GetComponent<PlayerScript>().enemyPrevPos = transform.position;
                Debug.Log("hi ;3");
                */
            }
            if (enemytype == "gungleguy")
            {
                enemyObj = this.gameObject;
                Debug.Log(enemytype);
                /*
                player.GetComponent<PlayerScript>().colEnemy = enemyObj;
                player.GetComponent<PlayerScript>().fighting = true;
                player.GetComponent<PlayerScript>().CancelAnimation();
                FightMenu.GetComponent<FightingFunctions>().StartFight();
                player.GetComponent<PlayerScript>().enemyScale = new Vector3(1.93f, 1.93f, 1.93f);
                player.GetComponent<PlayerScript>().enemyMove = new Vector3(-1980, -761, 0);
                player.GetComponent<PlayerScript>().enemyPrevPos = transform.position;
                Debug.Log("hi ;3");
                */
            }
            if (enemytype == "fabian")
            {
                enemyObj = this.gameObject;
                Debug.Log(enemytype);
                /*
                player.GetComponent<PlayerScript>().colEnemy = enemyObj;
                player.GetComponent<PlayerScript>().fighting = true;
                player.GetComponent<PlayerScript>().CancelAnimation();
                FightMenu.GetComponent<FightingFunctions>().StartFight();
                player.GetComponent<PlayerScript>().enemyScale = new Vector3(1.93f, 1.93f, 1.93f);
                player.GetComponent<PlayerScript>().enemyMove = new Vector3(-1980, -761, 0);
                player.GetComponent<PlayerScript>().enemyPrevPos = transform.position;
                Debug.Log("hi ;3");
                */
            }
            if (enemytype == "jakoblaghoul")
            {
                enemyObj = this.gameObject;
                Debug.Log(enemytype);
                /*
                player.GetComponent<PlayerScript>().colEnemy = enemyObj;
                player.GetComponent<PlayerScript>().fighting = true;
                player.GetComponent<PlayerScript>().CancelAnimation();
                FightMenu.GetComponent<FightingFunctions>().StartFight();
                player.GetComponent<PlayerScript>().enemyScale = new Vector3(1.93f, 1.93f, 1.93f);
                player.GetComponent<PlayerScript>().enemyMove = new Vector3(-1980, -761, 0);
                player.GetComponent<PlayerScript>().enemyPrevPos = transform.position;
                Debug.Log("hi ;3");
                */
            }
            if (enemytype == "kasei")
            {
                enemyObj = this.gameObject;
                Debug.Log(enemytype);
                /*
                player.GetComponent<PlayerScript>().colEnemy = enemyObj;
                player.GetComponent<PlayerScript>().fighting = true;
                player.GetComponent<PlayerScript>().CancelAnimation();
                FightMenu.GetComponent<FightingFunctions>().StartFight();
                player.GetComponent<PlayerScript>().enemyScale = new Vector3(1.93f, 1.93f, 1.93f);
                player.GetComponent<PlayerScript>().enemyMove = new Vector3(-1980, -761, 0);
                player.GetComponent<PlayerScript>().enemyPrevPos = transform.position;
                Debug.Log("hi ;3");
                */
            }
            if (enemytype == "marshall")
            {
                enemyObj = this.gameObject;
                Debug.Log(enemytype);
                /*
                player.GetComponent<PlayerScript>().colEnemy = enemyObj;
                player.GetComponent<PlayerScript>().fighting = true;
                player.GetComponent<PlayerScript>().CancelAnimation();
                FightMenu.GetComponent<FightingFunctions>().StartFight();
                player.GetComponent<PlayerScript>().enemyScale = new Vector3(1.93f, 1.93f, 1.93f);
                player.GetComponent<PlayerScript>().enemyMove = new Vector3(-1980, -761, 0);
                player.GetComponent<PlayerScript>().enemyPrevPos = transform.position;
                Debug.Log("hi ;3");
                */
            }
            if (enemytype == "thomas")
            {
                enemyObj = this.gameObject;
                Debug.Log(enemytype);
                /*
                player.GetComponent<PlayerScript>().colEnemy = enemyObj;
                player.GetComponent<PlayerScript>().fighting = true;
                player.GetComponent<PlayerScript>().CancelAnimation();
                FightMenu.GetComponent<FightingFunctions>().StartFight();
                player.GetComponent<PlayerScript>().enemyScale = new Vector3(1.93f, 1.93f, 1.93f);
                player.GetComponent<PlayerScript>().enemyMove = new Vector3(-1980, -761, 0);
                player.GetComponent<PlayerScript>().enemyPrevPos = transform.position;
                Debug.Log("hi ;3");
                */
            }
        }
    }


}
