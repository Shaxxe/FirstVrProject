using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;



public class Particleaktif : MonoBehaviour
{
    public ParticleSystem kivilcim;
    public GameObject modelkaynak;
    public GameObject demir1;
    public GameObject demir2;
    
    
    public Transform span;
    public XRGrabInteractable grap;
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        
        kivilcim.Stop();
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(Weld);
        grabbable.deactivated.AddListener(Weld1);
        demir1.GetComponent<Rigidbody>().velocity = Vector3.zero;
        demir1.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        demir2.GetComponent<Rigidbody>().velocity = Vector3.zero;
        demir2.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    
    }

    // Update is called once per frame
    void Update()
    {
       
    }
        
    
    public void Weld(ActivateEventArgs arg)
    {
        kivilcim.transform.position=span.transform.position;
        
        
        
        
        
    }
    public void Weld1(DeactivateEventArgs arg)
    {
        
        if (demir1.GetComponent<FixedJoint>() != null || demir2.GetComponent<FixedJoint>() != null)
        {
            // Demirler arasında zaten bir "FixedJoint" nesnesi oluşturulmuş
            // "FixedJoint" özelliğini kaldırın veya demirleri birbirinden ayrın
            
        }
        else
        {
            // Demirler arasında henüz bir "FixedJoint" nesnesi oluşturulmamış
            // "FixedJoint" nesnesini oluşturun ve demirleri birbirine bağlayın

            if ((modelkaynak.GetComponent<Collider>().bounds.Intersects(demir1.GetComponent<Collider>().bounds) || modelkaynak.GetComponent<Collider>().bounds.Intersects(demir2.GetComponent<Collider>().bounds)))
            {   
            
                demir2.transform.Translate(0,0,0);

                // DemirNesne1 ve DemirNesne2 nesnelerini birleştirin
                demir1.transform.parent = demir2.transform;

                // Demirlerin birbirine bağlanmasını sağlayacak "FixedJoint" nesnesini oluşturun
                FixedJoint fixedJoint = demir1.AddComponent<FixedJoint>();

                // Demirlerin birbirine bağlanmasını sağlayacak "FixedJoint" nesnesini ayarlayın
                fixedJoint.connectedBody = demir2.GetComponent<Rigidbody>();
                Vector3 combinedPosition = demir1.transform.position + demir2.transform.position;
                
                grap.enabled = true;
            }
        }
    }
}
