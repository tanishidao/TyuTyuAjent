using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(gameObject.CompareTag("Player1") && gameObject.CompareTag("Player2"))
        {
            SceneManager.LoadScene("SecondStage");
        }

    }
}
