using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSpellCheckFunctionality : MonoBehaviour
{
    [SerializeField] private GameObject prefabToReplaceWith;
    private GameObject instantiatedPrefab;
    private SpellInputProcessing instantiatedPrefabSPI;
    [SerializeField] private RectTransform parentCanvasPosition;
    [SerializeField] int siblingIndex;
    private SpellManager _spellManager;

    public int SiblingIndex { get => siblingIndex; set => siblingIndex = value; }

    private void Start()
    {
        //It's kinda weird, but GetComponentInParent returns RectTransform from a GameObject this script is attatched to, doing it this way ensures it gets skipped and finds the parent's
        //component instead
        parentCanvasPosition = GetComponentsInParent<RectTransform>()[1];
        _spellManager = GetComponentInParent<SpellManager>();
    }
    public void ReplacePrefab()
    {
        SiblingIndex = gameObject.transform.GetSiblingIndex();
        _spellManager.SpellSlotList.RemoveAt(SiblingIndex);
        instantiatedPrefab = Instantiate(prefabToReplaceWith, parentCanvasPosition);
        instantiatedPrefabSPI = instantiatedPrefab.GetComponent<SpellInputProcessing>();
        instantiatedPrefabSPI.SiblingIndex = SiblingIndex;
        instantiatedPrefabSPI.SpellManager = GetComponentInParent<SpellManager>();
        instantiatedPrefab.transform.SetSiblingIndex(SiblingIndex);
        _spellManager.SpellSlotList.Insert(SiblingIndex,instantiatedPrefab);
        instantiatedPrefabSPI.Sheet = GetComponentInParent<Sheet>();
        instantiatedPrefabSPI.UpdateSpellList();
        Destroy(gameObject);
    } 
}
