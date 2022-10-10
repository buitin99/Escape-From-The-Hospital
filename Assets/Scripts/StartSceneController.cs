using UnityEngine.InputSystem;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneController : MonoBehaviour
{
    private PlayerInputAction _playerInputAction;
    private string[] stringLevel = {"Scenes/Level1","Scenes/Level2","Scenes/Level3"};
    
    private void Awake() {
        _playerInputAction = new PlayerInputAction();
        
        _playerInputAction.Player.Move.performed += StartGame;
        _playerInputAction.Player.Move.canceled += StartGame;
    }


    private void OnEnable() {
        _playerInputAction.Enable();
    }

    private void StartGame(InputAction.CallbackContext ctx) {
        SceneManager.LoadScene(stringLevel[PlayerPrefs.GetInt("SelectedLevel",LoadScene.id)]);
    }

    public void GoToShopGame()
    {
       SceneManager.LoadScene("ShopGame"); 
    }

    public void GoToCharacters()
    {
        SceneManager.LoadScene("CharacterScene");
    }

    private void OnDestroy() {
        _playerInputAction.Player.Move.performed -= StartGame;
        _playerInputAction.Player.Move.canceled -= StartGame;
    }

}
