using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{   
    //crea un "Animator" que se llama Anim
    private Animator Anim;

    // Start is called before the first frame update
    void Start()
    {   
        //Asigna el componente Animator del objeto del juego a la variable Anim
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {   
        // verifica si la variable llamada Anim no está vacía.
        if (Anim != null)
        {
            //verifica si se ha presionado la tecla "Q"
            if(Input.GetKeyDown(KeyCode.Q)){
                // Tecla "Q" Activa la animaciñon "startWarmup"
                Anim.SetTrigger("startWarmup");
            }
            //verifica si se ha presionado la tecla "W"
            if(Input.GetKeyDown(KeyCode.W)){
                // Tecla "W" Activa la animaciñon "startWarmup"
                Anim.SetTrigger("startDance");
            }
            //verifica si se ha presionado la tecla "E"
            if(Input.GetKeyDown(KeyCode.E)){
                // Tecla "E" Activa la animaciñon "startWarmup"
                Anim.SetTrigger("startSpin");
            }
            //verifica si se ha presionado la tecla "R"
            if(Input.GetKeyDown(KeyCode.R)){
                // Tecla "R" Activa la animaciñon "startWarmup"
                Anim.SetTrigger("startFrontflip");
            }
        }
    }
}
