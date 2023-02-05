using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotBarDown : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "BulletK")
        {
            Destroy(other.gameObject);            
        }
        if (other.gameObject.tag == "BulletB")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "BulletWZ")
        {
            Destroy(other.gameObject);  
        }
        if (other.gameObject.tag == "BulletCR")
        {
            Destroy(other.gameObject);   
        }
        if (other.gameObject.tag == "BulletK2")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "BulletB2")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "BulletWZ2")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "BulletCR2")
        {
            Destroy(other.gameObject);
        }
    }
}
