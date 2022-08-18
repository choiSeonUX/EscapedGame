using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    private bool flashlightEnabled; 
    public GameObject flashlight;
    public GameObject lightObj;
    public float maxEnergy;
    private float currentEnergy;

    private int batteries;
    private GameObject batteryPickedUp;

    void Start()
    {
        currentEnergy = maxEnergy;
        maxEnergy = 50 * batteries;
        flashlightEnabled = false;

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F))
            flashlightEnabled =! flashlightEnabled;

        if (flashlightEnabled)
        {
            flashlight.SetActive(true);
            
            //currentEnergy -= 0.5f * Time.deltaTime;
        }
        else
        {
            flashlight.SetActive(false);
        }

    }

    //public void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "Battery")
    //        batteryPickedUp = other.gameObject;
    //    batteries += 1;
    //    Destroy(batteryPickedUp); 
                
                
    // }

}
