using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongDoor : MonoBehaviour
{
   
    private Animator anim; 

    private bool playEnterd; 
    private bool isOpen; 

    void Start()
    {
              
       anim = GetComponent<Animator>();
       playEnterd = true;  
       isOpen = false;
       anim.enabled = true; 

    }


    void Update()
    {
        if(isOpen)
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                anim.SetBool("open", playEnterd);
                playEnterd = !playEnterd; 
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            isOpen = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
      if(other.gameObject.tag == "Player")
        {
            isOpen = false; 
        }
    }
}
