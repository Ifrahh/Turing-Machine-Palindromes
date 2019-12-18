using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class screenswitch : MonoBehaviour
{
    public AudioSource a2;
    void Start()
    {

        a2.Play();
        // GameObject createdbutton = (GameObject)Instantiate(b1);
        GameObject.Find("b1").GetComponentInChildren<Text>().text = "Palindromes";
        GameObject.Find("b2").GetComponentInChildren<Text>().text = "Sharqa Hameed";
        GameObject.Find("b3").GetComponentInChildren<Text>().text = "Ifrah Ikram ";

    }
    public void Gotomaxscene()
    {
        //SceneManager.LoadScene("zerhash");
        SceneManager.LoadScene("maxcc");
      //  SceneManager.SetActiveScene(SceneManager.GetSceneByName("maxcc"));
    }

    public void Gotopalindromescene()
    {
        SceneManager.LoadScene("palindromes");
    }
    public void Goto0nhashn02n()
    {
       SceneManager.LoadScene("zerhash");
       // SceneManager.SetActiveScene(SceneManager.GetSceneByName("Scene2"));
    }
}


