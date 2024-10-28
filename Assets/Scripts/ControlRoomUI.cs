using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlRoomUI : MonoBehaviour
{
    [SerializeField] GameObject ControlPanel;

    public void OpenPanel()
    {
        ControlPanel.SetActive(true);
    }

    public void ClosePanel()
    {
        ControlPanel.SetActive(false);
    }
}
