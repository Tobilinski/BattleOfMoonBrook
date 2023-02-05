using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public int countdownTime;
    public Text countdownDisp;
    public float fireRate = 5f;
    public float nextFire = 0f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            StartCoroutine(CountDownStart());
        } 
    }

    public IEnumerator CountDownStart()
    {
        while (countdownTime > 0)
        {
            countdownDisp.text = countdownTime.ToString();
            yield return new WaitForSeconds(1f);
            countdownTime--;
        }

        countdownDisp.text = "Play";
        countdownTime = 5;

    }
}
