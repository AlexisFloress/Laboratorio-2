using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneric : Enemy
{
    public void atacar()
    {
        Debug.Log("ATACAR enemigo generico");
    }
    public void mover()
    {
        Debug.Log("MOVER enemigo generico");
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
