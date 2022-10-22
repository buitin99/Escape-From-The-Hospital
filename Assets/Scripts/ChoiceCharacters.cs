using UnityEngine;
using Cinemachine;

public class ChoiceCharacters : MonoBehaviour
{
    [SerializeField] ScriptedCharacters _scriptedCharacters;
    GameObject _character;
    [SerializeField] GameObject _positionSpawn;
    public CinemachineFreeLook CMFL;
    // Start is called before the first frame update
    void Start()
    {
        _character = _scriptedCharacters.character[0].character;
        Vector3 positonCharacter = _positionSpawn.transform.position;
        GameObject player = Instantiate(_character,positonCharacter,Quaternion.identity);
        CMFL.Follow = player.transform;     
        CMFL.LookAt = player.transform;     
    }

}
