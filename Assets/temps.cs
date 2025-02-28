using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class temps : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI _etiquetteTemps;

    public int Temps;
    private float codeTime;


    // Start is called before the first frame update
    void Start()
    {
        Temps = 0;

    }

    // Update is called once per frame
    void Update()
    {

        codeTime += 1* Time.deltaTime;

        Temps = Mathf.RoundToInt(codeTime);

        _etiquetteTemps.text = Temps.ToString();


    }
}
