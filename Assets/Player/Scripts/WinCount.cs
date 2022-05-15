using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCount : MonoBehaviour
{
    public DestroyObject script;
    public int count = 0;
    
    public int OnTriggerEnter(Collider other)
    {
        count++;

        return count;
    }

    private void Update()
    {
        Debug.Log(count);
    }
}
