using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abgerbaRadisana : MonoBehaviour{
    public GameObject cepure1;
    public GameObject cepure2;
    public GameObject cepure3;
    

    public void abgerbs1Attelosana(bool vertiba){
        cepure1.SetActive(vertiba);
    }
    public void abgerbs2Attelosana(bool vertiba)
    {
        cepure2.SetActive(vertiba);
    }
    public void abgerbs3Attelosana(bool vertiba)
    {
        cepure3.SetActive(vertiba);
    }
    
    
}
