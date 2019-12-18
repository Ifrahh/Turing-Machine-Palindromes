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

public class pscript : MonoBehaviour
{

    public Text t;
    public static int totalcubes;
    TextMesh tm;
    public InputField input;
    public GameObject field;
    string text, si, st;
    char[] tn;
    public int l;
    public Button Button;
    public GameObject g, cube;
    // public Button B1;// Start is called before the first frame update
    void Awake()
    {
        Button.GetComponentInChildren<Text>().text = "Start";
        input = GameObject.Find("InputField").GetComponent<InputField>();
       

    }

    public void Mainmenu()
    {
        SceneManager.LoadScene("scene1");
    }
    public void keylistener(string g)
    {
        //Regex rgx = new Regex(@"[^01 ]");



        if (Input.GetKey(KeyCode.Alpha0) || Input.GetKey(KeyCode.Alpha1))
        {
            input.text = input.text;
            si = input.text;
        }

        else
        {
            input.text = si + "";
            //  Debug.Log("enter binary number");
        }

    }



    public void GetInput(string guess)
    {

        string s;
        // Regex rgx = new Regex(@"[^01 ]");

        s = input.text;

        //  input.SetActive(false);
        //s = Regex.Replace(s, @"[^01 ]", "");
        char[] temp = s.ToCharArray();

        l = temp.Length;
        totalcubes = l + 2;
        st = "□" + s + "□";
        tn = st.ToCharArray();
        Debug.Log("with s we have" + st);
        //char[] tn = new char[l + 2];
        Array.Reverse(temp);
        string b = new string(temp);
        //       Debug.Log(th);
        // if (s.Equals(b))
        //{

        int x = 0;
        // Debug.Log("palindrome " + l);
        // t.text = "Palindromes ✔";
        field.SetActive(false);



        //Get the Renderer component from the new cube

        //  GameObject.Find("InputField").GetComponent("input").enabled = false;
        for (int i = 0; i <= l + 1; i++)
        {

            g = new GameObject();


            cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            //  cube.tag = "cube" + i;
            // GameObject cube = new GameObject();
            cube.name = "cube" + i;
            cube.transform.position = new Vector3(x, 0, 0);
            // cube.transform.rotation = new Vector3(0, 0, 0);
            cube.transform.Rotate(0, -250, 0);

            //  cube.transform.localScale= new Vector3(1, 1, 1);
            cube.SetActive(false);
            //  cube.transform.localScale = new Vector3(2, 1, 1);
            // cube.material.color = Color.black;
            // print(cube.transform.localPosition.x + " " + cube.transform.localPosition.y + " " + cube.transform.localPosition.z);
            //Debug.Log("position of cube");

            g.transform.position = new Vector3(x, 0, 0);
            //g.transform.localScale = new Vector3(1, 1, 1);
            //print(transform.localPosition.x +" " +transform.localPosition.y+" "+ transform.localPosition.z);
            g.name = "obj" + i;
            // cube.SetActive(false);
            g.AddComponent<MeshRenderer>();
            tm = g.AddComponent<TextMesh>();

            g.transform.localScale = new Vector3(0, 0, 0);
            //g.SetActive(false);

            //  g.GetComponent<Renderer>().material =  FontMaterialB;
            //tm.color = new Color32(255, 150, 10, 255);
            tm.color = new Color(0, 0, 0, 1);
            char ch = tn[i];
            string a = ch.ToString();
            tm.text = a;


            tm.characterSize = 0.25F;
            x = x + 2;
        }
        // }
        // else
        // {
        // t.text = "not palindromes ✖";
        // }
        // input.text = "";
    }
    public void Update()
    {



    }
}
