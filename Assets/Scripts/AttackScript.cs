using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AttackScript : MonoBehaviour
{
    //public Transform Camera;
    //public float throwforce = 10f;
    public Rigidbody rb;
    public void Start()
    {
         Rigidbody rb = GetComponent<Rigidbody>();
    }
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            ScoreScript.instance.ScoreAdd(1);
            
            rb.isKinematic = true;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
           

        }
    }
    //public void Update()
    //{
    //    if(Input.GetButtonDown("Fire1"))
    //    {
    //        kNIFE();
    //    }
        
    //}

    //public void kNIFE()
    //{
    //   rb.AddForce(Camera.forward * throwforce, ForceMode.Impulse);
    //}
}
