using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="CharacterInfo", menuName ="Scripted Objects/New Character Info")]
public class ScriptedCharacterInfo : ScriptableObject
{
    public string nameCharacter;
    public int cost;
    public GameObject character; 
}
