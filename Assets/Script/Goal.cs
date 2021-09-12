using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public string  SceneName;

    private float WaitTime;

    List<GameObject> colList = new List<GameObject>();
    // Update is called once per frame
    void Update()
    {
        if(colList.Count > 1)
        {
           
            Debug.Log("‚Å‚«‚½‚©‚à");
            WaitTime  += Time.deltaTime;
            if(WaitTime > 1f)
            {
                SceneManager.LoadScene(SceneName);
            }
            
        }
    }

  
    private void OnTriggerEnter2D(Collider2D other)
    {
       
        colList.Add(other.gameObject);
        Debug.Log("11111‚Å‚«‚½‚©‚à");
    }
}
