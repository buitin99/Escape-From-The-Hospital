using UnityEngine.InputSystem;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneController : MonoBehaviour
{
    private PlayerInputAction _playerInputAction;
    
    private void Awake() {
        _playerInputAction = new PlayerInputAction();
        
        _playerInputAction.Player.Move.performed += StartGame;
        _playerInputAction.Player.Move.canceled += StartGame;
    }


    private void OnEnable() {
        _playerInputAction.Enable();
    }

    private void StartGame(InputAction.CallbackContext ctx) {
        SceneManager.LoadScene("Level1");
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
