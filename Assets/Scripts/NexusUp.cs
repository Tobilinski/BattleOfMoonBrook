using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NexusUp : MonoBehaviour
{
    public int health = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            SceneManager.LoadScene("P1win");
        }
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
}
