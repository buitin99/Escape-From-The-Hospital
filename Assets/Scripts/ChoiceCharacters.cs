using UnityEngine;
using Cinemachine;

public class ChoiceCharacters : MonoBehaviour
{
    [SerializeField] ScriptedCharacters _scriptedCharacters;
    GameObject _character;
    public CinemachineFreeLook CMFL;
    // Start is called before the first frame update
    void Start()
    {
        _character = _scriptedCharacters.character[0].character;
        Vector3 positonCharacter = new Vector3(0,0,-17.7f);
        GameObject player = Instantiate(_character,positonCharacter,Quaternion.identity);
        CMFL.Follow = player.transform;     
        CMFL.LookAt = player.transform;     
    }

}
