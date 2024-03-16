using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metralleta : Weapon

{
    public void fire() {
        Debug.Log("muchos piu");
    }
    public void coolDown()
    {
        Debug.Log("mucho coolDown");
    }

    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            fire();
            coolDown();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
