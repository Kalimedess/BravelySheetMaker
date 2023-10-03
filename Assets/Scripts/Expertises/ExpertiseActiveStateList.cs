using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpertiseActiveStateList : MonoBehaviour
{
    [SerializeField] private Sheet _sheet;
    [SerializeField] private List<GameObject> expertiseDropdownsList;

    public void ProcessActiveDropdowns()
    {
        if (_sheet.EnabledExpertisesList.Count > 0)
            _sheet.EnabledExpertisesList.Clear();

        foreach (var expertise in expertiseDropdownsList)
        {
            if (expertise.activeSelf)
            {
                _sheet.EnabledExpertisesList.Add(true);
            }
            else
            {
                _sheet.EnabledExpertisesList.Add(false);
            }
        }
    }
    public void OnLoadSheet()
    {
        for(int i = 0; i < expertiseDropdownsList.Count; i++)
        {
            if (_sheet.EnabledExpertisesList[i])
            {
                if (expertiseDropdownsList[i].activeSelf) continue;
                expertiseDropdownsList[i].SetActive(true);
            }
            else
            {
                if (!expertiseDropdownsList[i].activeSelf) continue;
                expertiseDropdownsList[i].SetActive(false);
            }
        }
    }
}
