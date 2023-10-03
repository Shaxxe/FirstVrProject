using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GloveAttacher : MonoBehaviour
{
    // Oyuncunun eline giydirilecek eldivenleri temsil eden nesne
    public GameObject gloves;

    // Oyuncunun elini temsil eden nesne
    public GameObject hand;

    void Update() {
        // Eğer oyuncunun eline çarptıysa
        if (Input.GetButtonDown("GloveAttach")) {
            // Eldivenleri oyuncunun eline giydir
            AttachGloves();
        }
    }

    void AttachGloves() {
        // Eldivenleri oyuncunun eline giydir
        gloves.transform.parent = hand.transform;

        // Eldivenlerin pozisyonunu ve rotasyonunu ayarla
        gloves.transform.localPosition = Vector3.zero;
        gloves.transform.localRotation = Quaternion.identity;
    }
}

