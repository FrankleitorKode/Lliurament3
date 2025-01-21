using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TeclaPresionada : MonoBehaviour
{
    public UIDocument documentoUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
         // Obtener el Label que se llama Accion
        Label label = documentoUI.rootVisualElement.Q<Label>("Accion");
        // Verifica si se encontró el Label
        if (label != null)
        {   
            //si se presiona "Q" el laber dice "Warming up!"
            if (Input.GetKeyDown(KeyCode.Q))
            {
                {
                 // Cambia el texto del Label
                 label.text = "Warming up!";
                }  
            }
            //si se presiona "W" el label dice "Getting into the groove!"
            if (Input.GetKeyDown(KeyCode.W))
            {
                {
                 // Cambia el texto del Label
                 label.text = "Getting into the groove!";
                }  
            }
            //si se presiona "E" el label dice "Amazing technique"
            if (Input.GetKeyDown(KeyCode.E))
            {
                {
                 // Cambia el texto del Label
                 label.text = "Amazing technique";
                }  
            }
            //si se presiona "R" el label dice "Showstopper!"
            if (Input.GetKeyDown(KeyCode.R))
            {
                {
                 // Cambia el texto del Label
                 label.text = "Showstopper!";
                }  
            }
        }
    }
}
