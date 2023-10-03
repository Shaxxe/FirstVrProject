using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ISIN : MonoBehaviour
{
    public Transform ilkalan;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        XRSimpleInteractable grabbable = GetComponent<XRSimpleInteractable>();
        grabbable.selectExited.AddListener(col);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void col(SelectExitEventArgs arg)
    {
       player.transform.position=ilkalan.transform.position;
    }
}
