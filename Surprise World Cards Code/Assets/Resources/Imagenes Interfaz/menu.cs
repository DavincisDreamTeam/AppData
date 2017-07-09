using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour {

	public void GoToMainMenu()
    {
        Application.LoadLevel("Main_menu");
    }
    public void GoToARCamera()
    {
        Application.LoadLevel("SurpriseWorldCards");
    }
    public void GoToInfo()
    {
        Application.LoadLevel("Info1");
    }
    public void GoToMarkers()
    {
        Application.OpenURL("https://drive.google.com/open?id=0B7dyc0qwpscJLVFaUzBsRGhReGM");
    }
    public void ExitApplication()
    {
        Application.Quit();
    }
}
