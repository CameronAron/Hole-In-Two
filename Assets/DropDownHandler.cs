using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownHandler : MonoBehaviour
{
    public Dropdown SelectLevel;


    private void Start()
    {
        SelectLevel.onValueChanged.AddListener(delegate
        {
            SelectLevelChangeHappened(SelectLevel);
        });

    }

    public void SelectLevelChangeHappened(Dropdown sender)
    {
        Debug.Log(sender.value);
    }
}
