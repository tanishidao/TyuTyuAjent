using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMove : MonoBehaviour
{
    private float ChangeTime;
    private bool ChangeRoate = true;
    public GameObject Light;

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ChangeTime += Time.deltaTime;
        if (ChangeTime > 3f&& ChangeRoate == true)
        {
            Light.transform.position += new Vector3(6, 0, 0);
            Light.transform.Rotate(new Vector3(0, 180, 0));
            ChangeRoate = false;
            ChangeTime = 0;
            
        }
        if(ChangeTime > 3f && ChangeRoate == false)
        {
            Light.transform.position -= new Vector3(6, 0, 0);
            Light.transform.Rotate((new Vector3(0, -180, 0)));
            ChangeRoate = true;
            ChangeTime = 0;
            
           
        }

      
       




        

    }
}
