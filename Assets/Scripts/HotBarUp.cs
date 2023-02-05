using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotBarUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "BulletA")
        {
            Destroy(other.gameObject);          
        }
        if (other.gameObject.tag == "BulletW")
        {
            Destroy(other.gameObject);           
        }
        if (other.gameObject.tag == "BulletBM")
        {
            Destroy(other.gameObject);           
        }
        if (other.gameObject.tag == "BulletC")
        {
            Destroy(other.gameObject);          
        }
        if (other.gameObject.tag == "BulletA2")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "BulletW2")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "BulletBM2")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "BulletC2")
        {
            Destroy(other.gameObject);
        }
    }
}
