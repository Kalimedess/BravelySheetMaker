using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Class",menuName ="New Class")]
public class ClassSO : ScriptableObject
{
    public int healthBonus;
    public int masteryBonus;
    public int bulkBonus;
    public int memoryBonus;
    public int imaginationBonus;
    public int leadershipBonus;
    public int luckBonus;
}
