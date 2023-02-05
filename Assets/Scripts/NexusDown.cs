using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NexusDown : MonoBehaviour
{
    public int health = 60;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            SceneManager.LoadScene("P2win");
        }
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
}
