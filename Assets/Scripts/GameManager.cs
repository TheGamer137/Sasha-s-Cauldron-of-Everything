using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _settingsMenu, _mainMenu, 
        _addOrEditCharacterMenu, _charactersMenu;

    [SerializeField] private Transform _charactersPosition, _addOrEditCharacterPosition;
    // Start is called before the first frame update
    void Start()
    {
        _settingsMenu.transform.localScale = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenSettingsMenu()
    {
        _settingsMenu.transform.LeanScale(Vector2.one, 0.8f);
    }
    public void CloseSettingsMenu()
    {
        _settingsMenu.transform.LeanScale(Vector2.zero, 1f).setEaseInBack();
    }

    public void OpenHandbook()
    {
        Application.OpenURL("https://dnd.su/");
    }

    public void ReturnToMainMenu()
    {
        if (_addOrEditCharacterMenu.activeSelf || _charactersMenu.activeSelf)
        {
            _addOrEditCharacterMenu.SetActive(false);
            _charactersMenu.SetActive(false);
            _settingsMenu.LeanScale(Vector2.zero, 1f).setEaseInBack();
            _mainMenu.LeanScale(Vector2.one, 0.8f);
        }
    }
    public void OpenCharactersMenu()
    {
        _charactersMenu.SetActive(true);
        _mainMenu.transform.LeanScale(Vector2.zero, 1f).setEaseInBack();
        _charactersPosition.localPosition = new Vector2(0, -Screen.height);
        _charactersPosition.LeanMoveLocalY(0, 1f).setEaseOutExpo().delay = 1f;
    }
    public void OpenAddOrEditCharacterMenu()
    {
        _charactersPosition.LeanMoveLocalY(-Screen.height, 1f).setEaseInExpo();
        _addOrEditCharacterMenu.SetActive(true);
        _addOrEditCharacterPosition.localPosition = new Vector2(0, -Screen.height);
        _addOrEditCharacterPosition.LeanMoveLocalY(0, 1f).setEaseOutExpo().delay = 1f;
    }

    public void CloseAddOrEditCharacterMenu()
    {
        _addOrEditCharacterPosition.LeanMoveLocalY(-Screen.height, 1f).setEaseInExpo();
        _charactersPosition.LeanMoveLocalY(0, 1f).setEaseOutExpo().delay = 1f;
    }
}
