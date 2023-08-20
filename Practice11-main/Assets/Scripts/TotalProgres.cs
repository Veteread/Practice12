using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalProgres : MonoBehaviour
{
    public Text progres;
    void Update()
    {
        progres.text = DataContainer.SumBonus.ToString();
    }
}
