﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
namespace QuantumTek.EncryptedSave
{
    /// <summary> Shows how to use Encrypted Save. </summary>
    public class ES_Demo : MonoBehaviour
    {
        public InputField text;
        public Slider knobX;
        public Slider knobY;
        public RectTransform knob;

        public string bosses;
        public TextMeshProUGUI healthhodl;
        public int Health;
        public int Strength;
        public int gold;
        public string SceneName;
        public GameObject player;

        public GameObject inv;
        public GameObject QuickSlots;

        public float xPos;
        public float yPos;


        public string item1;
        public string item2;
        public string item3;
        public string item4;
        public string item5;
        public string item6;
        public string item7;
        public string item8;
        public string item9;
        public string item10;
        public string item11;
        public string item12;
        public string item13;
        public string item14;
        public string item15;
        public string item16;
        public string item17;
        public string item18;
        public string item19;
        public string item20;
        public string item21;
        public string item22;
        public string item23;
        public string item24;
        public string item25;
        public string item26;
        public string item27;
        public string item28;
        public string item29;
        public string item30;
        public string item31;
        public string item32;
        public string item33;
        public string item34;
        public string item35;
        public string item36;

        public GameObject template;


        public GameObject item1hold;

        public List<GameObject> everyItem = new List<GameObject>();

        void Start()
        {
            Health = player.GetComponent<PlayerScript>().playerHP;
            healthhodl.text = Health.ToString();
            SceneName = SceneManager.GetActiveScene().name;
        }

        void Update()
        {
            xPos = player.transform.position.x;
            yPos = player.transform.position.y;
        }

        public void inventorysave()
        {
            
            for (int i = 1; i < 36; i++)
            {
                inv.SetActive(true);
                QuickSlots.SetActive(true);

                if (QuickSlots.transform.GetChild(i - 1).gameObject.transform.childCount > 0)
                {

                    switch (i) 
                    {
                        case 0:
                            Debug.Log("hi :3");
                            break;
                        case 1:
                            item1 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 2:
                            item2 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 3:
                            item3 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 4:
                            item4 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 5:
                            item5 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 6:
                            item6 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 7:
                            item7 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 8:
                            item8 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 9:
                            item9 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 10:
                            item10 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 11:
                            item11 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 12:
                            item12 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 13:
                            item13 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 14:
                            item14 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 15:
                            item15 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 16:
                            item16 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 17:
                            item17 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 18:
                            item18 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 19:
                            item19 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 20:
                            item20 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 21:
                            item21 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 22:
                            item22 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 23:
                            item23 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 24:
                            item24 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 25:
                            item25 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 26:
                            item26 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 27:
                            item27 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 28:
                            item28 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 29:
                            item29 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 30:
                            item30 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 31:
                            item31 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 32:
                            item32 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 33:
                            item33 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 34:
                            item34 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 35:
                            item35 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                        case 36:
                            item36 = QuickSlots.transform.GetChild(i - 1).gameObject.transform.GetChild(0).gameObject.name.ToString();
                            break;
                    }
                }
                QuickSlots.SetActive(false);
                inv.SetActive(false);
            }
            
        }
        public void healthup()
        {
            Health++;
            healthhodl.text = Health.ToString();

        }

        public void healthdown()
        {
            Health--;
            healthhodl.text = Health.ToString();

        }

        
        public void SetKnobPos()
        {
            if (!knob || !knobX || !knobY) return;
            // Set knob position based on sliders
            knob.anchoredPosition = new Vector2(knobX.value, knobY.value);
        }

        

        public void Item1check()
        {
            if (item1 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item1, "item1 a");
            }
        }
        public void Item2check()
        {
            if (item2 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item2, "item2 a");
            }
        }
        public void Item3check()
        {
            if (item3 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item3, "item3 a");
            }
        }
        public void Item4check()
        {
            if (item1 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item4, "item4 a");
            }
        }
        public void Item5check()
        {
            if (item5 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item5, "item5 a");
            }
        }
        public void Item6check()
        {
            if (item6 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item6, "item6 a");
            }
        }
        public void Item7check()
        {
            if (item7 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item7, "item7 a");
            }
        }
        public void Item8check()
        {
            if (item8 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item8, "item8 a");
            }
        }
        public void Item9check()
        {
            if (item9 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item9, "item9 a");
            }
        }
        public void Item10check()
        {
            if (item10 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item10, "item10 a");
            }
        }
        public void Item11check()
        {
            if (item11 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item11, "item11 a");
            }
        }
        public void Item12check()
        {
            if (item12 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item12, "item12 a");
            }
        }
        public void Item13check()
        {
            if (item13 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item13, "item13 a");
            }
        }
        public void Item14check()
        {
            if (item14 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item14, "item14 a");
            }
        }
        public void Item15check()
        {
            if (item15 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item15, "item15 a");
            }
        }
        public void Item16check()
        {
            if (item16 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item16, "item16 a");
            }
        }
        public void Item17check()
        {
            if (item17 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item17, "item17 a");
            }
        }
        public void Item18check()
        {
            if (item18 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item18, "item18 a");
            }
        }
        public void Item19check()
        {
            if (item19 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item19, "item19 a");
            }
        }
        public void Item20check()
        {
            if (item20 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item20, "item20 a");
            }
        }
        public void Item21check()
        {
            if (item21 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item21, "item21 a");
            }
        }
        public void Item22check()
        {
            if (item22 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item22, "item22 a");
            }
        }
        public void Item23check()
        {
            if (item23 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item23, "item23 a");
            }
        }
        public void Item24check()
        {
            if (item24 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item24, "item24 a");
            }
        }
        public void Item25check()
        {
            if (item25 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item25, "item25 a");
            }
        }
        public void Item26check()
        {
            if (item26 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item26, "item26 a");
            }
        }
        public void Item27check()
        {
            if (item27 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item27, "item27 a");
            }
        }
        public void Item28check()
        {
            if (item28 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item28, "item28 a");
            }
        }
        public void Item29check()
        {
            if (item29 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item29, "item29 a");
            }
        }
        public void Item30check()
        {
            if (item30 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item30, "item30 a");
            }
        }
        public void Item31check()
        {
            if (item31 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item31, "item31 a");
            }
        }
        public void Item32check()
        {
            if (item32 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item32, "item32 a");
            }
        }
        public void Item33check()
        {
            if (item33 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item33, "item33 a");
            }
        }
        public void Item34check()
        {
            if (item34 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item34, "item34 a");
            }
        }
        public void Item35check()
        {
            if (item35 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item35, "item35 a");
            }
        }
        public void Item36check()
        {
            if (item36 == null)
            {
                Debug.Log("uh oh");
            }
            else
            {
                ES_Save.Save(item36, "item36 a");
            }
        }

        


        public void Save()
        {
            
            if (!text || !knob) return;
            // Saves the value of the text component.
            ES_Save.Save(SceneName, "Scene name");
            ES_Save.Save(text.text, "test string");
            ES_Save.SaveTransform(transform, "test transform");
            ES_Save.SaveRectTransform(knob, "test rect transform");
            ES_Save.Save(knobX.value, "test x");
            ES_Save.Save(knobY.value, "test y");
            
            //ES_Save.Save(Health.int, "test int");
            ES_Save.Save(Health, "test num");

            Debug.Log(yPos);
            Debug.Log(xPos);
            ES_Save.Save(xPos, "xpositionh");
            ES_Save.Save(yPos, "ypositionh");


            Item1check();
            Item2check();
            Item3check();
            Item4check();
            Item5check();
            Item6check();
            Item7check();
            Item8check();
            Item9check();
            Item10check();
            Item11check();
            Item12check();
            Item13check();
            Item14check();
            Item15check();
            Item16check();
            Item17check();
            Item18check();
            Item19check();
            Item20check();
            Item21check();
            Item22check();
            Item23check();
            Item24check();
            Item25check();
            Item26check();
            Item27check();
            Item28check();
            Item29check();
            Item30check();
            Item31check();
            Item32check();
            Item33check();
            Item34check();
            Item35check();
            Item36check();



        }

        public void Load()
        {
            
            if (!text || !knob || !knobX || !knobY) return;
            // Loads the saved value of the text component.
            text.text = ES_Save.Load<string>("test string");
            SceneName = ES_Save.Load<string>("Scene name");
            // Requests to load the saved transform data, which will load on the next LateUpdate call to the ES_Save GameObject, if there is one. Otherwise nothing will happen.
            ES_Save.LoadTransform(transform, "test transform");
            ES_Save.LoadRectTransform(knob, "test rect transform");
            knobX.value = ES_Save.Load<float>("test x");
            knobY.value = ES_Save.Load<float>("test y");
            
            //Health.int = ES_Save.Load<float>("test int");
            Health = ES_Save.Load<int>("test num");
            xPos = ES_Save.Load<float>("xpositionh");
            yPos = ES_Save.Load<float>("ypositionh");
            player.transform.position = new Vector3(xPos, yPos, transform.position.z);

            for (int i = 1; i < 36; i++)
            {

                switch (i)
                {
                    case 0:
                        Debug.Log("hi :3");
                        break;
                    case 1:
                        if (item1 != null)
                        {
                            item1 = ES_Save.Load<string>("item1 a");

                            //GameObject item1actual = Instantiate(GameObject.Find(item1), transform.position, Quaternion.identity);

                            //GameObject item1actual = Instantiate("Sword 7");

                            //GameObject item1actual = Resources.Load<GameObject>(item1);

                            //GameObject item1spawn = Instantiate(item1actual);

                            //item1actual.transform.parent = item1hold.transform;

                            //item1spawn.transform.parent = item1hold.transform;

                            //item1actual.tranform.localPosition = Vector3.zero;

                            //item1actual.tranform.localRotation = Quaternion.identity;

                            for (int j = 1; j < everyItem.Count + 1; j++)
                            {
                                if (everyItem[j - 1].name == item1)
                                {
                                    GameObject tempGameObj;
                                    Sprite newSprite;
                                    
                                    tempGameObj = everyItem[j - 1];
                                    GameObject.Find("inventory holder").SetActive(true);
                                    GameObject.Find("Inventory screen").SetActive(true);
                                    newSprite = tempGameObj.GetComponent<Image>().sprite;
                                    GameObject temp = Instantiate(template, new Vector3(0, 0, 0), Quaternion.identity);
                                    temp.GetComponent<Image>().sprite = newSprite;
                                    temp.name = everyItem[j - 1].name;
                                    temp.transform.SetParent(GameObject.Find("quick slots").transform.GetChild(i - i).gameObject.transform);
                                    GameObject.Find("inventory holder").SetActive(false);
                                    GameObject.Find("Inventory screen").SetActive(false);
                                }
                            }
                        }
                        break;
                    case 2:
                        if (item2 != null)
                        {
                            item2 = ES_Save.Load<string>("item2 a");
                        }
                        break;
                    case 3:
                        if (item3 != null)
                        {
                            item3 = ES_Save.Load<string>("item3 a");
                        }
                        break;
                    case 4:
                        if (item4 != null)
                        {
                            item4 = ES_Save.Load<string>("item4 a");
                        }
                        break;
                    case 5:
                        if (item5 != null)
                        {
                            item5 = ES_Save.Load<string>("item5 a");
                        }
                        break;
                    case 6:
                        if (item6 != null)
                        {
                            item6 = ES_Save.Load<string>("item6 a");
                        }
                        break;
                    case 7:
                        if (item7 != null)
                        {
                            item7 = ES_Save.Load<string>("item7 a");
                        }
                        break;
                    case 8:
                        if (item8 != null)
                        {
                            item8 = ES_Save.Load<string>("item8 a");
                        }
                        break;
                    case 9:
                        if (item9 != null)
                        {
                            item9 = ES_Save.Load<string>("item9 a");
                        }
                        break;
                    case 10:
                        if (item10 != null)
                        {
                            item10 = ES_Save.Load<string>("item10 a");
                        }
                        break;
                    case 11:
                        if (item11 != null)
                        {
                            item11 = ES_Save.Load<string>("item11 a");
                        }
                        break;
                    case 12:
                        if (item12 != null)
                        {
                            item12 = ES_Save.Load<string>("item12 a");
                        }
                        break;
                    case 13:
                        if (item13 != null)
                        {
                            item13 = ES_Save.Load<string>("item13 a");
                        }
                        break;
                    case 14:
                        if (item14 != null)
                        {
                            item14 = ES_Save.Load<string>("item14 a");
                        }
                        break;
                    case 15:
                        if (item15 != null)
                        {
                            item15 = ES_Save.Load<string>("item15 a");
                        }
                        break;
                    case 16:
                        if (item16 != null)
                        {
                            item16 = ES_Save.Load<string>("item16 a");
                        }
                        break;
                    case 17:
                        if (item17 != null)
                        {
                            item17 = ES_Save.Load<string>("item17 a");
                        }
                        break;
                    case 18:
                        if (item18 != null)
                        {
                            item18 = ES_Save.Load<string>("item18 a");
                        }
                        break;
                    case 19:
                        if (item19 != null)
                        {
                            item19 = ES_Save.Load<string>("item19 a");
                        }
                        break;
                    case 20:
                        if (item20 != null)
                        {
                            item20 = ES_Save.Load<string>("item20 a");
                        }
                        break;
                    case 21:
                        if (item21 != null)
                        {
                            item21 = ES_Save.Load<string>("item21 a");
                        }
                        break;
                    case 22:
                        if (item22 != null)
                        {
                            item22 = ES_Save.Load<string>("item22 a");
                        }
                        break;
                    case 23:
                        if (item23 != null)
                        {
                            item23 = ES_Save.Load<string>("item23 a");
                        }
                        break;
                    case 24:
                        if (item24 != null)
                        {
                            item24 = ES_Save.Load<string>("item24 a");
                        }
                        break;
                    case 25:
                        if (item25 != null)
                        {
                            item25 = ES_Save.Load<string>("item25 a");
                        }
                        break;
                    case 26:
                        if (item26 != null)
                        {
                            item26 = ES_Save.Load<string>("item26 a");
                        }
                        break;
                    case 27:
                        if (item27 != null)
                        {
                            item27 = ES_Save.Load<string>("item27 a");
                        }
                        break;
                    case 28:
                        if (item28 != null)
                        {
                            item28 = ES_Save.Load<string>("item28 a");
                        }
                        break;
                    case 29:
                        if (item29 != null)
                        {
                            item29 = ES_Save.Load<string>("item29 a");
                        }
                        break;
                    case 30:
                        if (item30 != null)
                        {
                            item30 = ES_Save.Load<string>("item30 a");
                        }
                        break;
                    case 31:
                        if (item31 != null)
                        {
                            item31 = ES_Save.Load<string>("item31 a");
                        }
                        break;
                    case 32:

                        if (item32 != null)
                        {
                            item32 = ES_Save.Load<string>("item32 a");
                        }
                        break;
                    case 33:
                        if (item33 != null)
                        {
                            item33 = ES_Save.Load<string>("item33 a");
                        }
                        break;
                    case 34:
                        if (item34 != null)
                        {
                            item34 = ES_Save.Load<string>("item34 a");
                        }
                        break;
                    case 35:
                        if (item35 != null)
                        {
                            item35 = ES_Save.Load<string>("item35 a");
                        }
                        break;
                    case 36:
                        if (item36 != null)
                        {
                            item36 = ES_Save.Load<string>("item36 a");
                        }
                        break;

                }
            }

            
        }
    }
}