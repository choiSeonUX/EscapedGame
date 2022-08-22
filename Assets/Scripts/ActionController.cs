using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 


public class ActionController : MonoBehaviour
{
    [SerializeField]
    private float range;

    private bool pickupActivated = false;

    private RaycastHit hitInfo;

    [SerializeField]
    private LayerMask layerMask;

    [SerializeField]
    private TextMeshProUGUI actionText;

    private void Update()
    {
        CheckItem(); 
        TryAction();
    }

    private void TryAction()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            CheckItem();
            CanPickUP();
        }
    }

    private void CanPickUP()
    {
        if(pickupActivated)
        {
            if(hitInfo.transform != null)
            {
                Debug.Log(hitInfo.transform.GetComponent<ItemPickUP>().item.itemName + "»πµÊ«ﬂΩ¿¥œ¥Ÿ"); 
                Destroy(hitInfo.transform.gameObject);
                InfoDisappear();
            }
        }
    }

    private void CheckItem()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hitInfo, range, layerMask))
        {
            if (hitInfo.transform.tag == "Item")
            {
                ItemInfoAppear();
            }
        }
        else
            InfoDisappear();
    }

    private void ItemInfoAppear()
    {
        Debug.Log("¡¶πﬂ ¡ª µ«∂Û");
        pickupActivated = true;
        actionText.gameObject.SetActive(true);
        actionText.text = hitInfo.transform.GetComponent<ItemPickUP>().item.itemName + "»πµÊ" + "<color=yellow>" + "(E)" + "</color>";
    }

    private void InfoDisappear()
    {
        pickupActivated = false;
        actionText.gameObject.SetActive(false); 
    }





}
