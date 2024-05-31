using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    [SerializeField] TMP_Dropdown dropdown;

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }

    public void SetVehicle()
    {
        MainManager.Instance.vehicleIndex = dropdown.value;
    }
}
