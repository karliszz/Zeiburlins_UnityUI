using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abgerba4Radisana : MonoBehaviour
{
    public GameObject kurpes1;
    public GameObject kurpes2;
    public GameObject kurpes3;


    public void abgerbs1Attelosana(bool vertiba)
    {
        kurpes1.SetActive(vertiba);
    }
    public void abgerbs2Attelosana(bool vertiba)
    {
        kurpes2.SetActive(vertiba);
    }
    public void abgerbs3Attelosana(bool vertiba)
    {
        kurpes3.SetActive(vertiba);
    }


}
