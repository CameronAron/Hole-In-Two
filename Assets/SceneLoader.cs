using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public Transform dropdownMenu;
    string value;

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(value);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get the selected index
        int menuIndex = dropdownMenu.GetComponent<Dropdown>().value;

        //get all options available wit$$anonymous$$n t$$anonymous$$s dropdown menu
        List<Dropdown.OptionData> menuOptions = dropdownMenu.GetComponent<Dropdown>().options;

        //get the string value of the selected index
        value = menuOptions[menuIndex].text;

        Debug.Log(value);
    }
}
