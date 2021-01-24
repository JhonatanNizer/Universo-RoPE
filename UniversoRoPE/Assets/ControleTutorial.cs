using System.Collections;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using UnityEngine;

public class ControleTutorial : MonoBehaviour {

    #region Variáveis
    public GameObject[] tutorialPages;
    public int counter;
    public BancoDeDados banco;
    public GameObject gameobject;
    public GameObject tutorial;
   // public GameObject menu_button_next;
    //public GameObject menu_button_previous;
    public GameObject BotoesGlobaes;

    #endregion

    void Start() {
        gameobject = GameObject.FindGameObjectWithTag("Bancodedados");
        banco = gameobject.GetComponent<BancoDeDados>();
    }

    public void OpenCloseTutorial() {
        if (tutorial.activeSelf) {
            tutorial.SetActive(false);
            // menu_button_next.SetActive(true);
            //menu_button_previous.SetActive(true);
            BotoesGlobaes.SetActive(true);
        } else {
            tutorial.SetActive(true);
            // menu_button_next.SetActive(false);
            //menu_button_previous.SetActive(false);
            BotoesGlobaes.SetActive(false);
            foreach (GameObject tp in tutorialPages) {
                tp.SetActive(false);
            }
            counter = 0;
            tutorialPages[0].SetActive(true);
        }
    }

    public void NextTutorialPage() {
        if(counter == tutorialPages.Length -1) {
            tutorial.SetActive(false);
            // menu_button_next.SetActive(true);
            // menu_button_previous.SetActive(true);
            BotoesGlobaes.SetActive(true);
            return;
        }
        tutorialPages[counter].SetActive(false);
        counter++;
        tutorialPages[counter].SetActive(true);
    }

    public void PreviousTutorialPage() {
        if(counter != 0) {
            tutorialPages[counter].SetActive(false);
            counter--;
            tutorialPages[counter].SetActive(true);
        }
    }

}
