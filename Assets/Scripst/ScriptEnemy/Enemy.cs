using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected void atacar()
    {
        Debug.Log("ATACAR");
    }
    protected void mover()
    {
        Debug.Log("MOVER");
    }
    // Start is called before the first frame update
    void Start()
    {
        atacar();
        mover();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
