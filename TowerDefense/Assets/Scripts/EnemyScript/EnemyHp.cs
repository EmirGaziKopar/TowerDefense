using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{

    LookAtTheEnemy lookAtTheEnemy;
    

    public static bool isDead;

    public static float tekMermiTekHasarSayacý = 0;
    public float characterHp = 1000;
    // Start is called before the first frame update
    void Start()
    {

        isDead = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "projectile") //gelen mermi tag'ý hangisiyse ona göre damage vurmasý ayarlanabilir.
        {
            Debug.Log("characterHp: " + characterHp); //Bilgisayar hýzýna baðlý olarak bu bölgede birden çok kare tekrar edebilir ve her bilgisayarýn hýzýna baðlý olarak düzensiz hp düþürür bunun önüne geçmek için bu kod satýrlarý her mermide bir defa çalýþsýn diye yukardaki sayaç parametresini kulladýk.
            characterHp -= 25; //gelen mermi tag'ý hangisiyse ona göre damage vurmasý ayarlanabilir.
            if (characterHp <= 0)
            {
                //sadece bir düþmana fokus olmayý saðlayan sayac                
                Destroy(this.gameObject);
                isDead = true;
            }

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "projectile") //gelen mermi tag'ý hangisiyse ona göre damage vurmasý ayarlanabilir.
        {
            Debug.Log("characterHp: " + characterHp); //Bilgisayar hýzýna baðlý olarak bu bölgede birden çok kare tekrar edebilir ve her bilgisayarýn hýzýna baðlý olarak düzensiz hp düþürür bunun önüne geçmek için bu kod satýrlarý her mermide bir defa çalýþsýn diye yukardaki sayaç parametresini kulladýk.
            characterHp -= 25; //gelen mermi tag'ý hangisiyse ona göre damage vurmasý ayarlanabilir.
            if (characterHp <= 0)
            {
                //sadece bir düþmana fokus olmayý saðlayan sayac                
                Destroy(this.gameObject);
                isDead = true;
            }

        }
    }
}
