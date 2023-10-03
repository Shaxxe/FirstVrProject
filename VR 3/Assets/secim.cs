using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secim : MonoBehaviour
{
    public GameObject butona,butonp,aktifmesaj,pasifmesaj;

    // Start is called before the first frame update
    void open()
    {
        aktifmesaj.SetActive(false);
        pasifmesaj.SetActive(true);
    }
    private void OnTriggerEnter(Collider other) {
        

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
