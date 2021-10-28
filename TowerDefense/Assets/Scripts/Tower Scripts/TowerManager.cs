using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{

    public GameObject gameController;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("carpti");
        if (collision.gameObject.CompareTag("enemy"))
        {
           Destroy(collision.gameObject);
            Debug.Log("carpisma basarili");
            gameController.GetComponent<GameController>().decreaseHP(0.1f);
            GameController.health -= 1f;
            //  Destroy(collision.gameObject);

        }
        if (collision.gameObject.CompareTag("ucak"))
        {

            gameController.GetComponent<GameController>().decreaseHP(0.3f);
            GameController.health -= 3f;
          //  Destroy(collision.gameObject);

        }
        if (collision.gameObject.CompareTag("tank"))
        {

            gameController.GetComponent<GameController>().decreaseHP(0.2f);
            GameController.health -= 2f;
           // Destroy(collision.gameObject);
        }
    }




}
