using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public static float tekMermiTekHasarSayac�=0;
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
        if(collision.gameObject.tag == "projectile" && tekMermiTekHasarSayac� == 0) 
        {
            tekMermiTekHasarSayac�++; 
            Debug.Log("characterHp: " + characterHp); //Bilgisayar h�z�na ba�l� olarak bu b�lgede birden �ok kare tekrar edebilir ve her bilgisayar�n h�z�na ba�l� olarak d�zensiz hp d���r�r bunun �n�ne ge�mek i�in bu kod sat�rlar� her mermide bir defa �al��s�n diye yukardaki saya� parametresini kullad�k.
            characterHp -= 10;
            if (characterHp <= 0)
            {
                LookAtTheEnemy.sayac = 0; //sadece bir d��mana fokus olmay� sa�layan sayac
                Destroy(this.gameObject);
            }
            
        }
    }
}
