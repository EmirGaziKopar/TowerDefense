using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public static float tekMermiTekHasarSayacý=0;
    public float characterHp=100;
    // Start is called before the first frame update
    void Start()
    {
        characterHp=100;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
            transform.Translate(transform.right*5f*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-transform.right * 5f * Time.deltaTime);
        }
        transform.Translate(-transform.right * 2f * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "projectile" && tekMermiTekHasarSayacý == 0) 
        {
            tekMermiTekHasarSayacý++; 
            Debug.Log("characterHp: " + characterHp); //Bilgisayar hýzýna baðlý olarak bu bölgede birden çok kare tekrar edebilir ve her bilgisayarýn hýzýna baðlý olarak düzensiz hp düþürür bunun önüne geçmek için bu kod satýrlarý her mermide bir defa çalýþsýn diye yukardaki sayaç parametresini kulladýk.
            characterHp -= 10;
            if (characterHp <= 0)
            {
                LookAtTheEnemy.sayac = 0; //sadece bir düþmana fokus olmayý saðlayan sayac
                Destroy(this.gameObject);
            }
            
        }
    }
}
