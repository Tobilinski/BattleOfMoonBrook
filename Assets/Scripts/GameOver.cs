using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public GameObject P2Card1,P2Card2,P2Card3;
    public GameObject P1Card1,P1Card2,P1Card3;


    public void LoadLevel()
    {
        

        P2Card1 = GameObject.FindGameObjectWithTag("P2Card");
        P1Card1 = GameObject.FindGameObjectWithTag("P1Card");
        if (P2Card1 == null)
        {

            SceneManager.LoadScene("P1win");
        }

        else if (P1Card1 == null)
        {
            SceneManager.LoadScene("P2win");

        }
    }

    

    void Start()
    {
       // NexusRed = GameObject.Find("NexusRed");
    }
    void Update()
    {
        
        LoadLevel();

    }
}