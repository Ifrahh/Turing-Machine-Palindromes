using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Text;
using TMPro;
using System.Text.RegularExpressions;
public class gamescript : MonoBehaviour
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

    void Awake()
    {
        Button.GetComponentInChildren<Text>().text = "Start";
        input = GameObject.Find("InputField").GetComponent<InputField>();
       

    }


    public void keylistener(string g)
    {
       
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.B) || Input.GetKey(KeyCode.C))
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
            cube.transform.Rotate(0,-250,0);

            cube.SetActive(false);
           
            g.transform.position = new Vector3(x, 0, 0);
            
            g.name = "obj" + i;
            // cube.SetActive(false);
            g.AddComponent<MeshRenderer>();
            tm = g.AddComponent<TextMesh>();

            g.transform.localScale = new Vector3(0, 0, 0);

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
