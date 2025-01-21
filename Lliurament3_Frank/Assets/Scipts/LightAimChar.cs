using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class LightAimChar : MonoBehaviour
{  
    //variable publica Transform para cambiar la posición, rotación y escala del objeto
    public Transform target;
    //variable numerica para determinar la velocidad de rotación
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        //el eje que este considerado "forward" apunta hacia el objetivo
        transform.LookAt(target);
    }

    // Update is called once per frame
    void Update()
    {      
        // hace que el objeto gire alrededor de un objeto en este caso, el objeto gira alrededor de "target.transform.position", la posición del objeto target. La velocidad de giro es "speed"(grados) por segundo.
        transform.RotateAround(target.transform.position, 
        new Vector3(0, 1, 0), speed * Time.deltaTime);
    }
}
