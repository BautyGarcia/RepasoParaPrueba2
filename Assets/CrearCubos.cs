using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrearCubos : MonoBehaviour
{
    public GameObject cuboPrefab;
    int CantidadCubos;
    public Text cantCubosTexto;
    public Text userOffset;

    public void CreacionCubos(){
        GameObject clon;
        float xOffset = int.Parse(userOffset.text);
        
        for(int i = 0; i < int.Parse(cantCubosTexto.text);i++){
            clon = Instantiate(cuboPrefab);

            clon.transform.position += new Vector3(xOffset,0,0);
            xOffset += 1.2f;
            Destroy(clon,5);
        }
    }
}
