using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abgerba2Radisana : MonoBehaviour
{
    public GameObject krekls1;
    public GameObject krekls2;
    public GameObject krekls3;


    public void abgerbs1Attelosana(bool vertiba)
    {
        krekls1.SetActive(vertiba);
    }
    public void abgerbs2Attelosana(bool vertiba)
    {
        krekls2.SetActive(vertiba);
    }
    public void abgerbs3Attelosana(bool vertiba)
    {
        krekls3.SetActive(vertiba);
    }


}
