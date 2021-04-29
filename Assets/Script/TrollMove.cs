using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrollMove : MonoBehaviour
{
     public Animator ani;

    void Start()
    {
        ani  = GetComponent<Animator>();     
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Time.deltaTime*1,0,0);
         ani.SetBool("RunTroll",false);
         ani.Play("TrollRun");
    }
}
