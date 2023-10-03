using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kablo : MonoBehaviour
{
    private LineRenderer kablo1;
    [SerializeField] private Transform[] kablouc;
    // Start is called before the first frame update
    void Start()
    {
        kablo1=GetComponent<LineRenderer>();
        kablo1.positionCount=kablouc.Length;
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0; i<kablouc.Length;i++)
        {
            kablo1.SetPosition(i,kablouc[i].position); 
        }
    }
}
