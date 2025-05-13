using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PropsInfo", menuName = "ScriptableObjects/PropsInfo", order = 1)]
public class PropsInfo : ScriptableObject
{
    public List<Information> information;
}

[System.Serializable]
public class Information
{
    public string title;
    [TextArea(0,20)]public string description;
    
}
