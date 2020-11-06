using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Document Content", menuName = "Player/Document Content")]
public class DocumentContent : ScriptableObject
{
    public new string name;
    [TextArea(10,20)]
    public string description;
    public Image icon; 
}
