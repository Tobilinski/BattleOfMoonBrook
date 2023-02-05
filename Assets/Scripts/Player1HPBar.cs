using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1HPBar : MonoBehaviour
{
    private Image HealthBar;
    public float curHealth;
    public float maxHealth = 60f;
    NexusUp P1HP;
    // Start is called before the first frame update
    void Start()
    {
        HealthBar = GetComponent<Image>();
        P1HP = FindObjectOfType<NexusUp>();
    }

    // Update is called once per frame
    void Update()
    {
        curHealth = P1HP.health;
        HealthBar.fillAmount = curHealth / maxHealth;
    }
}
