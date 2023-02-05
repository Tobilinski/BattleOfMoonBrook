using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2HPBar : MonoBehaviour
{
    private Image HealthBar;
    public float curHealth;
    public float maxHealth = 60f;
    NexusDown P2HP;
    // Start is called before the first frame update
    void Start()
    {
        HealthBar = GetComponent<Image>();
        P2HP = FindObjectOfType<NexusDown>();
    }

    // Update is called once per frame
    void Update()
    {
        curHealth = P2HP.health;
        HealthBar.fillAmount = curHealth / maxHealth;
    }
}
