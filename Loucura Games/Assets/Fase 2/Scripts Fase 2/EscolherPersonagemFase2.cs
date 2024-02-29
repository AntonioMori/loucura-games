using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EscolherPersonagemFase2 : MonoBehaviour
{
    public bool selectPersonagem1;
    public bool selectPersonagem2;
    bool Personagem1;
    bool Personagem2;
    public Image select1;
    public GameObject gameobject1;
    public Image select2;
    public GameObject gameobject2;
    
    void Update()
    {
        if (Input.GetKeyDown("left"))
        {
            selectPersonagem1 = true;
            selectPersonagem2 = false;
            //if (Input.GetKeyDown("Enter"))
            //{
            //    Personagem1 = true;
            //    Personagem2 = false;
            //}
        }

        if (Input.GetKeyDown("right"))
        {
            selectPersonagem2 = true;
            selectPersonagem1 = false;
            //if (Input.GetKeyDown("Enter"))
            //{
            //    Personagem1 = false;
            //    Personagem2 = true;
            //}
        }

        if (selectPersonagem1)
        {
            select1.GetComponent<Image>().color = new Color32(234, 140, 15, 100);
            select2.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
            if (Input.GetKeyDown("return"))
            {
                SceneManager.LoadScene("SubUrbanStage");
            }
        }

        if (selectPersonagem2)
        {
            select2.GetComponent<Image>().color = new Color32(234, 140, 15, 100);
            select1.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
            if (Input.GetKeyDown("return"))
            {
                SceneManager.LoadScene("CutsceneStage2");
            }
        }


    }
}