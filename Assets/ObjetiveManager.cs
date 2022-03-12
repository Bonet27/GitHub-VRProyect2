using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ObjetiveManager : MonoBehaviour
{
    public TextMeshPro Obj_rata;
    public TextMeshPro Obj_basura;
    public TextMeshPro Obj_ventanas;

    public Basura basurita;

    private void Update()
    {
        Obj_rata.text = ("Elimina roedores [" + basurita.contador_ratas + "/3]");
        Obj_basura.text = ("Recoge basura [" + basurita.contador + "/12]");
        Obj_ventanas.text = ("Abre ventanas [" + basurita.contador + "/6]");
        
        //Obj_ventanas.text = ("Recoge Basura [" + basurita.contador + "/20]");


    }
}
