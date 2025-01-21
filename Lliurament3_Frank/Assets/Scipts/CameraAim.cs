using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class CameraAim : MonoBehaviour
{  
    //variable publica Transform para cambiar la posición, rotación y escala del objeto
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        //el eje que este considerado "forward" apunta hacia el objetivo
        transform.LookAt(target);
    }

    // Update is called once per frame
    void Update()
    {      
        
    }
}
