using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Characters", menuName ="Scripted Objects/New Characters")]
public class ScriptedCharacters : ScriptableObject
{
    public int cost;
    public ScriptedCharacterInfo[] character;
}
