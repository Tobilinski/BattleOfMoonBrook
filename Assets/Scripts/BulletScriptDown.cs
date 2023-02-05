using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScriptDown : MonoBehaviour
{
    private int BSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.up * -1 * BSpeed * Time.deltaTime, Space.World);
        
    }
}
