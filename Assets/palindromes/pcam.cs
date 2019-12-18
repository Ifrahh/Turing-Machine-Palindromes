using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Text;
using TMPro;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;
public class pcam : MonoBehaviour
{
   
    public ParticleSystem ps;
    int speed = 20;
    public GameObject panel;
    public Material material;
    string su, zero, one, blank;
    string text, s, s2, txt;
    public Text currentstate, nextstate, operation;
    public Text currentstatetext, nextstatetext, operationtext;
    int e, p;
    int j = 2;
    int i, x = 0;
    GameObject g0, c0, g1, c1, g2, c2;
    TextMesh tm0, tm1, tm2;
    string inputtext, b, st;
    //  Cube cube;
    //Vector3 MyGameObjectPosition;
     public pscript g;
      public ad x1;
    char[] temp;
    char[] tn;
    public Button Button;
    int n = 1;
    string cstate = "q0";
    public bool bounds;

    public void reset()
    {
      
       
       
        int y = SceneManager.GetActiveScene().buildIndex;
        SceneManager.UnloadSceneAsync(y);
        SceneManager.LoadScene("palindromes");
    }
    public void Gotomain()
    {
        //SceneManager.LoadScene("zerhash");

       
        
        int y = SceneManager.GetActiveScene().buildIndex;
        SceneManager.UnloadSceneAsync(y);
        SceneManager.LoadScene("menu1");
        //  SceneManager.SetActiveScene(SceneManager.GetSceneByName("maxcc"));
    }
    public void TurnRed()
    {

        ColorBlock colors = Button.colors;
        colors.normalColor = Color.red;
        colors.highlightedColor = new Color32(255, 100, 100, 255);
        Button.GetComponentInChildren<Text>().text = "Rejected";
        Button.colors = colors;
    }

    public void TurnGreen()
    {

        ColorBlock colors = Button.colors;
        colors.normalColor = Color.green;
        colors.highlightedColor = new Color32(255, 100, 100, 255);
        Button.GetComponentInChildren<Text>().text = "Accepted";
        Button.colors = colors;
    }
    public void GetInput(string guess)
    {
        inputtext = g.input.text;
        e = g.l;
        e = e + 2;
        p = e - 1;
        p = p * 2;
        print("so lets go" + e);
        zero = "0";
        one = "1";
        blank = "□";
        //  input.SetActive(false);
        //s = Regex.Replace(s, @"[^01 ]", "");
        temp = inputtext.ToCharArray();

        // l = temp.Length;
        /// totalcubes = l + 2;
        st = "□" + inputtext + "□";
        tn = st.ToCharArray();
        Debug.Log("with s we have" + st);
        g0 = new GameObject();


        c0 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        c0.name = "c0";

        g0.name = "O0";
        // cube.SetActive(false);
        g0.AddComponent<MeshRenderer>();
        tm0 = g0.AddComponent<TextMesh>();

        g0.transform.localScale = new Vector3(3,3,3);
        tm0.color = new Color(0, 0, 0, 1);


        tm0.characterSize = 0.30F;

        g1 = new GameObject();


        c1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        c1.name = "c1";

        g1.name = "O1";
        // cube.SetActive(false);
        g1.AddComponent<MeshRenderer>();
        tm1 = g1.AddComponent<TextMesh>();

        g1.transform.localScale = new Vector3(3, 3, 3);
        tm1.color = new Color(0, 0, 0, 1);



        tm1.characterSize = 0.30F;
        g2 = new GameObject();


        c2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        c2.name = "c2";

        g2.name = "O2";
        // cube.SetActive(false);
        g2.AddComponent<MeshRenderer>();
        tm2 = g2.AddComponent<TextMesh>();

        g2.transform.localScale = new Vector3(3, 3, 3);
        tm2.color = new Color(0, 0, 0, 1);

        tm2.characterSize = 0.30F;
        c0.transform.localScale = new Vector3(0, 0, 0);
        g0.transform.localScale = new Vector3(0, 0, 0);
        c1.transform.localScale = new Vector3(0, 0, 0);
        g1.transform.localScale = new Vector3(0, 0, 0);
        c2.transform.localScale = new Vector3(0, 0, 0);
        g2.transform.localScale = new Vector3(0, 0, 0);

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int first = n - 1;
            int second = n + 1;
            string a0, a1, a2;
            TextMesh q1, q11, q111;
            c0.transform.localScale = new Vector3(3, 3, 3);
            g0.transform.localScale = new Vector3(3, 3, 3);
            c1.transform.localScale = new Vector3(3, 3, 3);
            g1.transform.localScale = new Vector3(3, 3, 3);
            c2.transform.localScale = new Vector3(3, 3, 3);
            g2.transform.localScale = new Vector3(3, 3, 3);
            c0.transform.position = new Vector3(0, 0, 0);
            c0.transform.Rotate(0, -250, 0);
            g0.transform.position = new Vector3(0, 0, 0);

            c1.transform.position = new Vector3(6, 0, 0);
            c1.transform.Rotate(0, -250, 0);
            g1.transform.position = new Vector3(6, 0, 0);

            c2.transform.position = new Vector3(12, 0, 0);
            c2.transform.Rotate(0, -250, 0);
            g2.transform.position = new Vector3(12, 0, 0);



            Debug.Log("reached :)");
            TextMesh q = GameObject.Find("obj" + n).GetComponent<TextMesh>();
            string w = q.GetComponent<TextMesh>().text;
            Debug.Log(w);
            if (cstate == "q0")
            {


                if (w == "0")
                {
                    q1 = GameObject.Find("obj" + first).GetComponent<TextMesh>();
                    a0 = q1.GetComponent<TextMesh>().text;
                    tm0.text = a0;
                    q11 = GameObject.Find("obj" + n).GetComponent<TextMesh>();
                    a1 = q11.GetComponent<TextMesh>().text;
                    tm1.text = a1;
                    q111 = GameObject.Find("obj" + second).GetComponent<TextMesh>();
                    a2 = q111.GetComponent<TextMesh>().text;
                    tm2.text = a2;
                    GameObject.Find("obj" + n).GetComponent<TextMesh>().text = "□";
                    currentstate.text = "q0";
                    nextstate.text = "q1";
                    operation.text = "right";
                    transform.position += Vector3.right * speed * Time.deltaTime;
                    cstate = "q1";
                    n++;

                    x1.ff();
                }//q0 0

                else if (w == "□")
                {

                    GameObject.Find("obj" + n).GetComponent<TextMesh>().text = "□";
                    currentstate.text = "q0";
                    nextstate.text = "q6";
                    operation.text = "right";
                    transform.position += Vector3.right * speed * Time.deltaTime;
                    cstate = "q6";
                    n++;

                    x1.ff();

                }// q0 y
                else if (w == "1")
                {
                    q1 = GameObject.Find("obj" + first).GetComponent<TextMesh>();
                    a0 = q1.GetComponent<TextMesh>().text;
                    tm0.text = a0;
                    q11 = GameObject.Find("obj" + n).GetComponent<TextMesh>();
                    a1 = q11.GetComponent<TextMesh>().text;
                    tm1.text = a1;
                    q111 = GameObject.Find("obj" + second).GetComponent<TextMesh>();
                    a2 = q111.GetComponent<TextMesh>().text;
                    tm2.text = a2;
                    GameObject.Find("obj" + n).GetComponent<TextMesh>().text = "□";
                    currentstate.text = "q0";
                    nextstate.text = "q4";
                    operation.text = "right";
                    transform.position += Vector3.right * speed * Time.deltaTime;
                    cstate = "q4";
                    n++;
                    x1.ff();
                }

            }//ifq0
            else if (cstate == "q1")
            {
                if (w == "0" || w == "1")
                {
                    q1 = GameObject.Find("obj" + first).GetComponent<TextMesh>();
                    a0 = q1.GetComponent<TextMesh>().text;
                    tm0.text = a0;
                    q11 = GameObject.Find("obj" + n).GetComponent<TextMesh>();
                    a1 = q11.GetComponent<TextMesh>().text;
                    tm1.text = a1;
                    q111 = GameObject.Find("obj" + second).GetComponent<TextMesh>();
                    a2 = q111.GetComponent<TextMesh>().text;
                    tm2.text = a2;
                    GameObject.Find("obj" + n).GetComponent<TextMesh>().text = GameObject.Find("obj" + n).GetComponent<TextMesh>().text;
                    currentstate.text = "q1";
                    nextstate.text = "q1";
                    operation.text = "right";
                    transform.position += Vector3.right * speed * Time.deltaTime;
                    cstate = "q1";
                    n++;
                    x1.ff();
                }//else if q1
                else if (w == "□")
                {

                    GameObject.Find("obj" + n).GetComponent<TextMesh>().text = "□";
                    currentstate.text = "q1";
                    nextstate.text = "q2";
                    operation.text = "left";
                    transform.position += Vector3.left * speed * Time.deltaTime;
                    cstate = "q2";
                    n--;
                    x1.bb();
                }//q1 y


            }//q1
            else if (cstate == "q2")
            {
                if (w == "□")
                {

                    GameObject.Find("obj" + n).GetComponent<TextMesh>().text = "□";
                    currentstate.text = "q2";
                    nextstate.text = "q6";
                    operation.text = "right";
                    transform.position += Vector3.right * speed * Time.deltaTime;
                    cstate = "q6";
                    n++;
                    x1.ff();
                }//q2 1
                else if (w == "0")
                {
                    q1 = GameObject.Find("obj" + first).GetComponent<TextMesh>();
                    a0 = q1.GetComponent<TextMesh>().text;
                    tm0.text = a0;
                    q11 = GameObject.Find("obj" + n).GetComponent<TextMesh>();
                    a1 = q11.GetComponent<TextMesh>().text;
                    tm1.text = a1;
                    q111 = GameObject.Find("obj" + second).GetComponent<TextMesh>();
                    a2 = q111.GetComponent<TextMesh>().text;
                    tm2.text = a2;
                    GameObject.Find("obj" + n).GetComponent<TextMesh>().text = "□";
                    currentstate.text = "q2";
                    nextstate.text = "q3";
                    operation.text = "left";
                    transform.position += Vector3.left * speed * Time.deltaTime;
                    cstate = "q3";
                    n--;
                    x1.bb();
                }//q2 z
                else if (w == "1")
                {
                    x1.r.Play();
                    TurnRed();
                }
            }
            else if (cstate == "q3")
            {
                if (w == "0" || w == "1")
                {
                    q1 = GameObject.Find("obj" + first).GetComponent<TextMesh>();
                    a0 = q1.GetComponent<TextMesh>().text;
                    tm0.text = a0;
                    q11 = GameObject.Find("obj" + n).GetComponent<TextMesh>();
                    a1 = q11.GetComponent<TextMesh>().text;
                    tm1.text = a1;
                    q111 = GameObject.Find("obj" + second).GetComponent<TextMesh>();
                    a2 = q111.GetComponent<TextMesh>().text;
                    tm2.text = a2;
                    GameObject.Find("obj" + n).GetComponent<TextMesh>().text = GameObject.Find("obj" + n).GetComponent<TextMesh>().text;
                    currentstate.text = "q3";
                    nextstate.text = "q3";
                    operation.text = "left";
                    transform.position += Vector3.left * speed * Time.deltaTime;
                    cstate = "q3";
                    n--;
                    x1.bb();
                }//q3 z
                else if (w == "□")
                {
                    //x1.accepted.Play();
                    GameObject.Find("obj" + n).GetComponent<TextMesh>().text = "□";
                    currentstate.text = "q3";
                    nextstate.text = "q0";
                    operation.text = "right";
                    transform.position += Vector3.right * speed * Time.deltaTime;
                    cstate = "q0";
                    n++;
                    x1.ff();
                }
            }


            //q2
            else if (cstate == "q4")
            {
                if (w == "0" || w == "1")
                {
                    q1 = GameObject.Find("obj" + first).GetComponent<TextMesh>();
                    a0 = q1.GetComponent<TextMesh>().text;
                    tm0.text = a0;
                    q11 = GameObject.Find("obj" + n).GetComponent<TextMesh>();
                    a1 = q11.GetComponent<TextMesh>().text;
                    tm1.text = a1;
                    q111 = GameObject.Find("obj" + second).GetComponent<TextMesh>();
                    a2 = q111.GetComponent<TextMesh>().text;
                    tm2.text = a2;
                    GameObject.Find("obj" + n).GetComponent<TextMesh>().text = GameObject.Find("obj" + n).GetComponent<TextMesh>().text;
                    currentstate.text = "q4";
                    nextstate.text = "q4";
                    operation.text = "right";
                    transform.position += Vector3.right * speed * Time.deltaTime;
                    cstate = "q4";
                    n++;
                    x1.ff();
                }//q3 z
                else if (w == "□")
                {

                    GameObject.Find("obj" + n).GetComponent<TextMesh>().text = "□";
                    currentstate.text = "q4";
                    nextstate.text = "q5";
                    operation.text = "left";
                    transform.position += Vector3.left * speed * Time.deltaTime;
                    cstate = "q5";
                    n--;
                    x1.bb();

                }//q3 1


            }//q3
            else if (cstate == "q5")
            {
                if (w == "□")
                {

                    GameObject.Find("obj" + n).GetComponent<TextMesh>().text = "□";
                    currentstate.text = "q5";
                    nextstate.text = "q6";
                    operation.text = "right";
                    transform.position += Vector3.right * speed * Time.deltaTime;
                    cstate = "q6";
                    n++;
                    x1.ff();

                }//q4 y
                else if (w == "1")
                {
                    q1 = GameObject.Find("obj" + first).GetComponent<TextMesh>();
                    a0 = q1.GetComponent<TextMesh>().text;
                    tm0.text = a0;
                    q11 = GameObject.Find("obj" + n).GetComponent<TextMesh>();
                    a1 = q11.GetComponent<TextMesh>().text;
                    tm1.text = a1;
                    q111 = GameObject.Find("obj" + second).GetComponent<TextMesh>();
                    a2 = q111.GetComponent<TextMesh>().text;
                    tm2.text = a2;
                    GameObject.Find("obj" + n).GetComponent<TextMesh>().text = "□";
                    currentstate.text = "q5";
                    nextstate.text = "q3";
                    operation.text = "left";
                    transform.position += Vector3.left * speed * Time.deltaTime;
                    cstate = "q3";
                    n--;
                    x1.bb();
                }//q4 z

                else if (w == "0")
                {
                    x1.r.Play();
                    TurnRed();

                }
            }//q4
            else if (cstate == "q6")
            {

                TurnGreen();
                x1.accepted.Play();
                q1 = GameObject.Find("obj" + first).GetComponent<TextMesh>();
                a0 = q1.GetComponent<TextMesh>().text;
                tm0.text = a0;
                q11 = GameObject.Find("obj" + n).GetComponent<TextMesh>();
                a1 = q11.GetComponent<TextMesh>().text;
                tm1.text = a1;
                q111 = GameObject.Find("obj" + second).GetComponent<TextMesh>();
                a2 = q111.GetComponent<TextMesh>().text;
                tm2.text = a2;




            }
           






        }//space
    }
}
