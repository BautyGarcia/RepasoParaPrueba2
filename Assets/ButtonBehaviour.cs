using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehaviour : MonoBehaviour
{
    public GameObject Capsula;
    public Text InputText;
    public Text OutputText;
    public InputField IField;
    int cantMaxPrefabs;
    int restatnes;
    int enteredNumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ComportamientoBoton(){
        enteredNumber = int.Parse(InputText.text);
        IField.readOnly = true;

        if (enteredNumber <= 0){

            OutputText.text = "No se puede poner un numero menor o igual a 0";
            return;
        }
        if (cantMaxPrefabs < enteredNumber-1){

            Instantiate(Capsula);

            cantMaxPrefabs++;

            restatnes = enteredNumber-cantMaxPrefabs;

            OutputText.text = "Quedan "+restatnes+" clones";

        } else {

            OutputText.text = "No quedan clones restantes";
            return;
        }

    }
}
