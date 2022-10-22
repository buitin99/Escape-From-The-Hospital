using UnityEngine.InputSystem;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class StartSceneController : MonoBehaviour
{
    private PlayerInputAction _playerInputAction;
    // {"StartScene","ShopGame","SelectLevelScene","CharactersGameMain","CompleteScene","LoseScene","Level1"}
    public static int idScene = 6;

     private PlayerData playerData;

    private UIDocument _doc;
    private Button _playButton;
    // private Button _settingsButton;
    // private Button _shopButton;
    // private Button _charactersButton;
    // private Button _exitButton;

    private void Awake() {
        _playerInputAction = new PlayerInputAction();
        _doc = GetComponent<UIDocument>();
        _playButton = _doc.rootVisualElement.Q<Button>("PlayButton");
        // _settingsButton = _doc.rootVisualElement.Q<Button>("SettingsButton");
        // _shopButton = _doc.rootVisualElement.Q<Button>("ShopButton");
        // _charactersButton = _doc.rootVisualElement.Q<Button>("CharactersButton");
        // _exitButton = _doc.rootVisualElement.Q<Button>("ExitButton");

        _playButton.clicked += GoToPlay;
        
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

    private void GoToPlay()
    {
        SceneManager.LoadScene(ScenesManager.scenesLoad[PlayerPrefs.GetInt(PrefConst.CURENT_LEVELS)+idScene]);        
    }
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
