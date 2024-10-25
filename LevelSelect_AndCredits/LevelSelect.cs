using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public GameObject levelSelect;
    public GameObject credits;
    public Scrollbar scrollbar;

    public Button level1;
    public Button level2;
    public Button level3;
    public Button level4;
    public Button level5;
    public Button creditsButton;

    // Start is called before the first frame update
    void Start()
    {
        credits.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (credits.activeSelf == true && Input.GetButtonDown("Cancel"))
        {
            levelSelect.SetActive(true);
            credits.SetActive(false);
        }
    }

    public void GoToLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void GoToLevel2()
    {
        // put code for scene transition to level 2 here
    }
    public void GoToLevel3()
    {
        SceneManager.LoadScene("Level 3");
    }
    public void GoToLevel4()
    {
        // put code for scene transition to level 4 here
    }
    public void GoToLevel5()
    {
        // put code for scene transition to level 5 here
    }
    public void ShowCredits()
    {
        levelSelect.SetActive(false);
        credits.SetActive(true);
        scrollbar.value = 1;
    }
}
