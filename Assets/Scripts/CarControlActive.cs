using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControlActive : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject CarControl;
    public GameObject Dreamcar01;
    void Start()
    {
     	CarControl.GetComponent<CarController>().enabled = true;
	Dreamcar01.GetComponent<CarAIControl>().enabled = true;   
    }
}
