using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBridge : MonoBehaviour
{
    private float _dirX;
    public float speed = 3f;

    private bool _moveingRight = true;
    
    void Update()
    {
        if (transform.position.x > 2f)
        {
            _moveingRight = false;
        }
        else if (transform.position.x < -2f)
        {
            _moveingRight = true;
        }

        if (_moveingRight)
        {
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
        }
    }
}
