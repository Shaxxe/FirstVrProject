using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secme : MonoBehaviour

{
    public GameObject butondogru;
    public GameObject dogrucevap;
    public GameObject  simdiki_canvas;


    public void dogru(){
        dogrucevap.SetActive(true);
        simdiki_canvas.SetActive(false);
    }
}
