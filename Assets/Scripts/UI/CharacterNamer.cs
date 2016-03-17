using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CharacterNamer : MonoBehaviour
{
	void Start ()
    {
        GetComponent<Text>().text = PlayerPrefs.GetString("playerName");
	}
}
