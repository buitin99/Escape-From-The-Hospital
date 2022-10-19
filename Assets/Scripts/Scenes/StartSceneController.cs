using UnityEngine.InputSystem;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneController : MonoBehaviour
{
    private PlayerInputAction _playerInputAction;
    // {"StartScene","ShopGame","SelectLevelScene","CharactersGameMain","CompleteScene","LoseScene","Level1"}
    public static int idScene = 6;

     private PlayerData playerData;
    
    private void Awake() {
        _playerInputAction = new PlayerInputAction();
        
        // _playerInputAction.Player.Move.performed += StartGame;
        // _playerInputAction.Player.Move.canceled += StartGame;

        // playerData = PlayerData.Load();
    }

    private void OnEnable() {
        _playerInputAction.Enable();
    }

    // private void StartGame(InputAction.CallbackContext ctx) {
        // if (PlayerPrefs.GetInt(PrefConst.CURENT_LEVELS) < 1 )
        // {
        //     SceneManager.LoadScene(ScenesManager.scenesLoad[idScene]);
        // }
        // else
        // {
        //     SceneManager.LoadScene(ScenesManager.scenesLoad[PlayerPrefs.GetInt(PrefConst.CURENT_LEVELS)+idScene]);
        // }

        // Player.LoadPlayer();

        // play.LoadPlayer();

    

        // if (play.level < 1)
        // {
        //     SceneManager.LoadScene(ScenesManager.scenesLoad[idScene]);
        // }
        // else
        // {
        //     SceneManager.LoadScene(ScenesManager.scenesLoad[play.level]+idScene); 
        // }
            // SceneManager.LoadScene(ScenesManager.scenesLoad[TriggerEnd.idLevel]); 
            // SceneManager.LoadScene(ScenesManager.scenesLoad[playerData.totalLevel]); 
        
    // }

    public void GoToShopGame()
    {
       SceneManager.LoadScene(ScenesManager.scenesLoad[1]); 
    }
    public void GoToSelectLevel()
    {
        SceneManager.LoadScene(ScenesManager.scenesLoad[2]);
    }
    public void GoToCharacters()
    {
        SceneManager.LoadScene(ScenesManager.scenesLoad[3]);
    }

    public void Got1()
    {
        SceneManager.LoadScene(ScenesManager.scenesLoad[PlayerPrefs.GetInt(PrefConst.CURENT_LEVELS)+idScene]);
    }

    // private void OnDestroy() {
    //     _playerInputAction.Player.Move.performed -= StartGame;
    //     _playerInputAction.Player.Move.canceled -= StartGame;
    // }

}
