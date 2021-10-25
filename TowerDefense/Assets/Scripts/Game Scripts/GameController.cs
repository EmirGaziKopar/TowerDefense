using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{

    // Daha pratik bir yolla yap þuan aklýma gelmedi
    public GameObject gameOverPanel;
    public bool Bolum1, Bolum2 ,Bolum3;
    public static  float health = 9f;
    public TMP_Text enemyCounter;
    public TMP_Text coinText;
    public static int coin = 500;
    public Image hp;
    public GameObject[] Turrets;
    public GameObject[] GunpowderTurrets;
    public GameObject[] AntiArmorTurrets;
    public GameObject[] SuperPowersTurrets;
    public GameObject[] InstantiateTurrets;
    
    // Start is called before the first frame update
    void Start()
    {
       
        if (Bolum1)
        {
            coin = 500;
            coinText.text = " " + coin;
            


        }
        if (Bolum2)
        {
            coin = 400;
            coinText.text = " " + coin;



        }
        if (Bolum3)
        {
            coin = 500;
            coinText.text = " " + coin;



        }

        
    }



    public void decreaseHP(float darbe)
    {
        
        hp.fillAmount -= darbe;
        if (health == 0f)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;

        }

    }
    // Update is called once per frame
    void Update()
    {
        if (coin >= 100)
        {
           // Debug.Log(coin);
            Turrets[0].GetComponent<Button>().interactable = false; //Çalýþýyor ama her panel için ayrý yapmak gerekiyor
            Turrets[0].GetComponentInChildren<Image>().color = new Color(85, 77, 77, 255); // Çalýþmýyor






        }



        enemyCounter.text = "" + AgentManager.EnemyCounter;




    }

    public void TurretController(int indis)
    {

        switch(indis){



            case 0:
                Debug.Log("button1");
                Instantiate(InstantiateTurrets[0]);

            //Bura Deðiþecek
            coin -= 100;
            break;
           
            case 1:
                Debug.Log("button2");
                Instantiate(InstantiateTurrets[1]);
                //Bura Deðiþecek
                break;
            case 2:
                Instantiate(InstantiateTurrets[2]);
                //Bura Deðiþecek
                break;
            case 3:
                Instantiate(InstantiateTurrets[3]);
                //Bura Deðiþecek
                break;

            case 4:
                Instantiate(InstantiateTurrets[4]);
                break;
            //Bura Deðiþecek
            case 5:
                Instantiate(InstantiateTurrets[5]);
                //Bura Deðiþecek
                break;


        }



      


    }


}
