using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MillRotation : MonoBehaviour
{

    [SerializeField] float _speed = 1;

    [SerializeField] bool _rotationX = false;
    [SerializeField] bool _rotationY = false;
    [SerializeField] bool _rotationZ = false;
    
    

    void Start()
    {
        
    }

    
    void Update()
    {
        if (_rotationZ == true)
        {
            Vector3 rotZ = new Vector3(0, 0, 1);
            transform.Rotate(rotZ, _speed * Time.deltaTime);
        } 
        else if (_rotationY == true)
        {
            Vector3 rotY = new Vector3(0, 1, 0);
            transform.Rotate(rotY, _speed * Time.deltaTime);
        }
        else if (_rotationX == true)
        {
            Vector3 rotX = new Vector3(1, 0, 0);
            transform.Rotate(rotX, _speed * Time.deltaTime);
        }

    }
}
