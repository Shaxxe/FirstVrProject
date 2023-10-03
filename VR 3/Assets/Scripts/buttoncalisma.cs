using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class buttoncalisma : MonoBehaviour
{
    public GameObject butona;
    public GameObject butonp;
    public bool aktif=true;
    void Start()
    {
        XRSimpleInteractable grabbable = GetComponent<XRSimpleInteractable>();
        grabbable.selectEntered.AddListener(col);
        
    }

    private void col(SelectEnterEventArgs arg)
    {
       if(aktif==true)
       {
         butona.SetActive(false);
         butonp.SetActive(true);
         aktif=false;
       }
       else if(aktif==false)
       {
        butonp.SetActive(false);
        butona.SetActive(true);
        aktif=true;
       }
    }
    
}

