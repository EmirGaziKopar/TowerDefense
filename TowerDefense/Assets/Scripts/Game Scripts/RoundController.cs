using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundController : MonoBehaviour
{
    bool isPlaying,beginingOfRound;
    public static bool isSpawnEnemy;
    public Button roundButton;
    AgentManager agentManager;
   public static int roundChecker;
    int indis = 0;
    public int[] RoundCounter;
   
    // Start is called before the first frame update
    void Start()
    {
        
        agentManager = GetComponent<AgentManager>();
        roundChecker = RoundCounter[indis];
        Debug.Log(roundChecker);
        
    }
    


    public void startRound()
    {
        isPlaying = true;
        indis++;
        roundChecker = RoundCounter[indis];
        Debug.Log(roundChecker);
        isSpawnEnemy = true;
        
       // agentManager.AgentInstantiate();
        roundButton.gameObject.SetActive(false);




    }
    void AddSources()
    {
        if (isPlaying==false && beginingOfRound==true)
        {

            GameController.coin += 200;
            roundButton.gameObject.SetActive(true);


        }

    }




    // Update is called once per frame
    void Update()
    {
      
        
        if (AgentManager.EnemyCounter == 0 )
        {
            isPlaying = false;
            beginingOfRound = true;
          
            

        }
    }
}
