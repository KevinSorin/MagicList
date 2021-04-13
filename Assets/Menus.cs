using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Vuforia;

public class Menus : MonoBehaviour
{
    public GameObject mainPanel, ListeDeCourse, CreerListe;

    void Start()
    {
        ListeDeCourse.SetActive(false);
        CreerListe.SetActive(false);
    }

    void Update()
    {
        
    }

    public void GoToListeDeCourse()
    {
        ListeDeCourse.SetActive(true);
        mainPanel.SetActive(false);
        CreerListe.SetActive(false);
        VuforiaBehaviour.Instance.enabled = false;
    }

    public void GoToMainMenu()
    {
        ListeDeCourse.SetActive(false);
        mainPanel.SetActive(true);
        CreerListe.SetActive(false);
        VuforiaBehaviour.Instance.enabled = true;
    }

    public void GoToCreerListe()
        {
            ListeDeCourse.SetActive(false);
            mainPanel.SetActive(false);
            CreerListe.SetActive(true);
            VuforiaBehaviour.Instance.enabled = false;
        }
}
