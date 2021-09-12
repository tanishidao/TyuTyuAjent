using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    private int TrapCount = 0;
    public int Click= 10;
    public int Mouse;
    public GameObject Player;

    bool Fleeze = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        if ( Fleeze == true && Input.GetMouseButtonDown(Mouse))
        {
            TrapCount++;
            Debug.Log(TrapCount);
        }
        if (TrapCount >= Click)
        {
            Fleeze = false;
            LockPos();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        Fleeze = true;
        LockPos();
      
    }

    void LockPos()
    {
        Rigidbody2D PlayerRig = Player.GetComponent<Rigidbody2D>();
        if (Fleeze == true)
        {

            PlayerRig.constraints = RigidbodyConstraints2D.FreezePosition;
        }
        else
        {
            PlayerRig.constraints = RigidbodyConstraints2D.None;
        }
    }




    ///•‰‚ÌˆâŽY
    ///Vector2 GetForce(Vector2 pos)
    /// {
    ////  float dist = Vector2.Distance(transform.position, pos);
    //// Vector2 dir = Player.transform.position - transform.position;
    ////  return dir.normalized / (dist* dist) * -1f;
    ///  }
}
