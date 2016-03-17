using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SettingsManager : MonoBehaviour
{
    void Start()
    {
        // PlayerPrefs.DeleteAll();
        InputField field = GetComponent<InputField>();
        field.text = PlayerPrefs.GetString("playerName");

    }

    public void ChangePlayerName()
    {
        InputField field = GetComponent<InputField>();

        PlayerPrefs.SetString("playerName", field.text);
    }
}
