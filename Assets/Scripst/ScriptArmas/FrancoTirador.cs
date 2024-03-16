using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrancoTirador : Weapon
{   
    public void fire()
    {
        Debug.Log("Solo un piu");
    }
    public void coolDown()
    {
        Debug.Log("Recarga");
    }

    private void Start()
    {
        fire();
        coolDown();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
