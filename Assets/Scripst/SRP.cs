using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class SRP : MonoBehaviour
{
    [SerializeField] float steerSpeed = 200f;
    [SerializeField] float moveSpeed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        if (Input.GetButtonDown("Horizontal"))
        {
            Debug.Log("Se esta moviendo Horizontalmente");
        }
      
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        if (Input.GetButtonDown("Vertical"))
        {
            Debug.Log("Se esta moviendo Verticalmente");
        }
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
        
    }
}
