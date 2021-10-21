using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine;
public class GameController : MonoBehaviour
{

    // Daha pratik bir yolla yap þuan aklýma gelmedi
    public GameObject gameOverPanel;
    public bool Bolum1, Bolum2 ,Bolum3;
    public static  float health = 9f;
    public TextMeshPro enemyCounter;
    public TextMeshPro coinText;
    int coin = 500;
    public Image hp;
    public GameObject[] Turrets;
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

    }

    public void TurretController(int indis)
    {
        switch(indis){

            case 0:
                Instantiate(InstantiateTurrets[0]);
                //Bura Deðiþecek
                break;

            case 1:
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
