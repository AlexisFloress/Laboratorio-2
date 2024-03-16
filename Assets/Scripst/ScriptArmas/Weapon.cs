using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    protected void fire()
    {
        if(Input.GetButtonDown("Fire1")) 
        {
            Debug.Log("piu piu");
        }
        
    }
    private void Update()
    {
        fire();
    }

}
