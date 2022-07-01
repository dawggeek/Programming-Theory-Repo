using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class TitleScreenUi : MonoBehaviour
{
    private TMP_InputField nameInput;

    // Start is called before the first frame update
    void Start()
    {
        nameInput = GetComponentInChildren<TMP_InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        PersistenceManager.Instance.playerName = nameInput.text;
        SceneManager.LoadScene("SampleScene");
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
