using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpertiseToggleButton : MonoBehaviour
{
    private GameObject expertiseDropdown;

    public void ToggleDropdown(GameObject dropdown)
    {
        if(dropdown.activeSelf)
        {
            dropdown.SetActive(false);
        }
        else
        {
            dropdown.SetActive(true);
        }
    }
}
