using System.IO;//Added this myself
using System;//Added this one
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using Unity.UI.Text;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif 

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    //public Text NamePicker;
    public GameObject NameField;
    public TextMeshProUGUI NameFieldText;
    public void NewNameWritten(Text name){
        MainManager.Instance.PlayerName = name;
    }

    // Start is called before the first frame update
    private void Start()
    {
        NameFieldText = NameField.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame(){
        SceneManager.LoadScene("Main");
    }
    public void Exit(){
        #if UNITY_EDITOR
                EditorApplication.ExitPlaymode();
        #else
                Application.Quit(); // original code to quit Unity player
        #endif
    }
    public void SaveNameClicked(){
        MainManager.Instance.PlayerName.text = NameFieldText.text;
        MainManager.Instance.SaveName();
    }

    public void LoadNameClicked(){
        MainManager.Instance.LoadName();
        //NamePicker.SelectName(MainManager.Instance.Name);
    }
}
