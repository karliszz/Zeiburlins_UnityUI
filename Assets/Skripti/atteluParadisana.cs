using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class atteluParadisana : MonoBehaviour
{
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;
    public GameObject slaideris;
    public GameObject slaideris1;

    public void izkritosais(int skaitlis)
    {
        if (skaitlis == 0)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];

        }
        else if (skaitlis == 1)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];
        }
    }
            public void mainitLielumu()
    {
        float pasreizejaVertiba = slaideris.GetComponent<Slider>().value;
        mainigaisAttels.transform.localScale = new Vector3(1F * pasreizejaVertiba, 1, 1);
    }
    public void mainitGarumu()
    {
        float pasreizejaVertiba = slaideris1.GetComponent<Slider>().value;
        mainigaisAttels.transform.localScale = new Vector3(1, 1F * pasreizejaVertiba, 1);
    }
}

