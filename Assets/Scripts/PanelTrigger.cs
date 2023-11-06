using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelTrigger : MonoBehaviour
{
    public GameObject carPanel;
    public GameObject RefrigeratorPanel;
    public GameObject LaundryMachinePanel;
    public GameObject ThermostatPanel;
    public GameObject LightBulbPanel;
    public GameObject ComputerPanel;


    private void OnTriggerEnter(Collider other)
    {
        if(this.name == "CarPanelTrigger")
        {
            Time.timeScale = 0;
            carPanel.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }

        if (this.name == "RefrigeratorPanelTrigger")
        {
            Time.timeScale = 0;
            RefrigeratorPanel.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }

        if (this.name == "LaundryMachinePanelTrigger")
        {
            Time.timeScale = 0;
            LaundryMachinePanel.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }

        if (this.name == "ThermostatPanelTrigger")
        {
            Time.timeScale = 0;
            ThermostatPanel.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }

        if (this.name == "LightBulbPanelTrigger")
        {
            Time.timeScale = 0;
            LightBulbPanel.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }

        if (this.name == "ComputerPanelTrigger ")
        {
            Time.timeScale = 0;
            ComputerPanel.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
    }

    public void ExitOut()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }


}
