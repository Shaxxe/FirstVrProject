using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectableObject : MonoBehaviour
{
    public Color selectedColor = Color.yellow;
    private Color originalColor;
    private bool isSelected = false;

    private void Start()
    {
        originalColor = GetComponent<Renderer>().material.color;
    }

    public void OnMouseDown()
    {
        isSelected = !isSelected;
        UpdateColor();
    }

    private void UpdateColor()
    {
        if (isSelected)
        {
            GetComponent<Renderer>().material.color = selectedColor;
        }
        else
        {
            GetComponent<Renderer>().material.color = originalColor;
        }
    }
}