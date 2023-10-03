using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpertiseToggleButton : MonoBehaviour
{
    private GameObject expertiseDropdown;
    private bool dropdownActivationState = true;

    public void ToggleDropdown(GameObject dropdown)
    {
        if(dropdown.activeSelf)
        {
            dropdown.SetActive(false);
            dropdownActivationState = false;
        }
        else
        {
            dropdown.SetActive(true);
            dropdownActivationState = true;
        }
    }
}
