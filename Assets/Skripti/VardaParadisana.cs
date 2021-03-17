using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//jaimporte lai varetu stradat ar ui
using UnityEngine.UI;
public class VardaParadisana : MonoBehaviour
{
    //Mainigaja saglabas tekstu ko raksta tekasta lauka
    public string teksts, teksts1;

    //lauks, kura ierakta tekstu
    public GameObject ievadesLauks;
    public GameObject ievadesLauks2;
    //kur attelo tekstu
    public GameObject tekstaAttelosana;

    //funksija tiek izsaukta nospiezot pogu
    public void uzglabatTekstu()
    {
        teksts = ievadesLauks.GetComponent<Text>().text;
        teksts1 = ievadesLauks2.GetComponent<Text>().text;
        tekstaAttelosana.GetComponent<Text>().text ="Sveiki "+teksts+" jums ir "+teksts1+" gadu!";
    }

}
