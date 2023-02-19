using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Video_Settings : MonoBehaviour
{
    public Dropdown resolutionDropdown;
    public Dropdown qualityDropdown;
    Resolution[] resolutions;
  //  public bool isFullScreen;
    public Toggle isFullScreenToggle;


    public const string saveKey = "Setings_Menu_Save";


    void Start()
    {
        resolutionDropdown.ClearOptions();
        List<string> options = new List<string>();
        resolutions = Screen.resolutions;
        //int currentResolutionIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "X" + resolutions[i].height +" "+ resolutions[i].refreshRate + "Hz";
            options.Add(option);
            //if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            //{
            //    currentResolutionIndex = i;
            //}
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.RefreshShownValue();
      //  SetResolution(currentResolutionIndex);
        Load_Video_Settings();
    }

    public void SetFullscreen(bool isFullscreen)
    {
        isFullScreenToggle.isOn = isFullscreen;
        Screen.fullScreen= isFullscreen;
    }

    public void SetResolution(int resolutionIndex)
    {
        resolutionDropdown.value = resolutionIndex;
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width,resolution.height,Screen.fullScreen);
    }

    public void SetQuality(int qualityIndex)
    {
        qualityDropdown.value= qualityIndex;
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void Load_Video_Settings()
    {
        var data = SaveManager.Load<SaveData.Menu_Save>(saveKey);

        SetFullscreen(data.isFull_screen);
        SetResolution(data.ResolutionIndex);
        SetQuality(data.QualityIndex); 

    }

    public void SaveVideoSettings()
    {
        SaveManager.Save(saveKey, GetSaveSnapshot());
    }

    private SaveData.Menu_Save GetSaveSnapshot()
    {
        var data = new SaveData.Menu_Save()
        {
            isFull_screen = isFullScreenToggle.isOn,
            ResolutionIndex = resolutionDropdown.value,
            QualityIndex = qualityDropdown.value

        };
        return data;
    }

}
