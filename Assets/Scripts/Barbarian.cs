using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barbarian : MonoBehaviour
{
    public int health = 15;
    public GameObject Bullet;
    public Transform bodytrans;
    public float fireRate = 5f;
    public float nextFire = 0f;
   
  //public int countdownTime;
  //public Text countdownDisp;


    public Text txt;
    // Update is called once per frame
    void Update()
    {
        //If health is 0 the cards gets destroyed
        if (health <= 0)
        {
            health = 0;
            Destroy(gameObject);
        }
        if (Input.GetKeyDown(KeyCode.LeftControl) && Time.time > nextFire )
        {
            nextFire = Time.time + fireRate;
            Shoot();
            //StartCoroutine(CountDownStart());
            
        }
        txt.text = "Barbarian Health = " + health;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "BulletA")
        {
            Destroy(other.gameObject);
            //how much damage Archer does
            health -= 7;
        }
        if (other.gameObject.tag == "BulletW")
        {
            Destroy(other.gameObject);
            //how much damage Warrior does
            health -= 4;
        }
        if (other.gameObject.tag == "BulletBM")
        {
            Destroy(other.gameObject);
            //how much damage Beastmaster does
            health -= 4;
        }
        if (other.gameObject.tag == "BulletC")
        {
            Destroy(other.gameObject);
            //how much damage Captain does
            health -= 5;
        }




        if (other.gameObject.tag == "BulletA2")
        {
            Destroy(other.gameObject);
            //how much damage Archer does
            health -= 7;
        }
        if (other.gameObject.tag == "BulletW2")
        {
            Destroy(other.gameObject);
            //how much damage Warrior does
            health -= 4;
        }
        if (other.gameObject.tag == "BulletBM2")
        {
            Destroy(other.gameObject);
            //how much damage Beastmaster does
            health -= 4;
        }
        if (other.gameObject.tag == "BulletC2")
        {
            Destroy(other.gameObject);
            //how much damage Captain does
            health -= 5;
        }
    }
    void Shoot()
    {
        Instantiate(Bullet, bodytrans.transform.position, bodytrans.rotation);
    }


    /*public IEnumerator CountDownStart()
    {
        while (countdownTime > 0)
        {
            countdownDisp.text = countdownTime.ToString();
            yield return new WaitForSeconds(1f);
            countdownTime--;
        }

        countdownDisp.text = "Play";
        countdownTime = 5;

    }*/
}
