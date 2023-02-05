using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BeastMaster2 : MonoBehaviour
{
    public int health = 10;
    public GameObject Bullet;
    public Transform bodytrans;
    public float fireRate = 5f;
    public float nextFire = 0f;

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
        if (Input.GetKeyDown(KeyCode.LeftControl) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Shoot();

        }
        txt.text = health + " = Beast Master2 Health";
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "BulletWZ")
        {
            Destroy(other.gameObject);
            //how much damage Wizard does
            health -= 7;
        }
        if (other.gameObject.tag == "BulletK")
        {
            Destroy(other.gameObject);
            //how much damage knight does
            health -= 5;
        }
        if (other.gameObject.tag == "BulletB")
        {
            Destroy(other.gameObject);
            //how much damage Barbarian does
            health -= 4;
        }

        if (other.gameObject.tag == "BulletCR")
        {
            Destroy(other.gameObject);
            //how much damage Crusader does
            health -= 4;
        }


        if (other.gameObject.tag == "BulletWZ2")
        {
            Destroy(other.gameObject);
            //how mcuh damage Wizard does
            health -= 7;
        }
        if (other.gameObject.tag == "BulletK2")
        {
            Destroy(other.gameObject);
            //how mcuh damage knight does
            health -= 5;
        }
        if (other.gameObject.tag == "BulletB2")
        {
            Destroy(other.gameObject);
            //how mcuh damage Barbarian does
            health -= 4;
        }
        if (other.gameObject.tag == "BulletCR2")
        {
            Destroy(other.gameObject);
            //how much damage Crusader does
            health -= 4;
        }
    }
    void Shoot()
    {
        Instantiate(Bullet, bodytrans.transform.position, bodytrans.rotation);
    }
}
