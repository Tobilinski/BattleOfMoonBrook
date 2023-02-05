using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private int BSpeed = 1;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.up * BSpeed * Time.deltaTime, Space.World);
        
    }
}
