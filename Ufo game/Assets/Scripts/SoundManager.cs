using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundManager : MonoBehaviour
{
    // Makes the variable private but shows up on the editor
    [SerializeField] Image soundOnIcon;
    [SerializeField] Image soundOffIcon;
    private bool muted = false;

    // Start is called before the first frame update
    void Start()
    {
        // if they are no save data from the previous game session muted will be set to 0 so muted will be false
        // Else if there are saved data from the previous game session the load function will be called
        if(!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }

        else
        {
            Load();
        }
        
        UpdateButtonIcon();
        AudioListener.pause = muted;
    }
   
    public void OnButtonPress()
    {
        // If the sound button is pressed and the game is not muted it will disbale all sounds from the game
        // Else if the game is already muted and if the sound button is pressed it will instead enable all sounds from the game
        if(muted == false)
        {
            muted = true;
            AudioListener.pause = true;
        }

        else
        {
            muted = false;
            AudioListener.pause = false;
        }
        Save();
        UpdateButtonIcon();
    }
    
    private void UpdateButtonIcon()
    {
        // if muted is false sound on icon is set and sound off icon is off 
        // else if muted is not false and is true sound on icon is off and sound off icon is set
        if(muted == false)
        {
            soundOnIcon.enabled = true;
            soundOffIcon.enabled = false;
        }

        else
        {
            soundOnIcon.enabled = false;
            soundOffIcon.enabled = true;
        }
    }

    private void Load()
    {
        // checks if muted equals to 1 and if it is equal to 1 muted is set to true
        // And if muted is not equal to 1 which makes it 0 then muted is set to false
        muted = PlayerPrefs.GetInt("muted") == 1;
    }

    private void Save()
    {
        // evaluates the bool
        // if muted is true the first value before the colon which is 1 is being used 
        // if muted is false the second value after the colon which is 0 is being used
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }
}
