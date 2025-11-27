using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using TMPro;
public class FileREad : MonoBehaviour
{
    string content = "hello";
    string path = "D:/AiPath/samples.txt";
    public Text txts;
    List<string> files = new List<string>();
    public Button btn;
    public Text t;
    int timers = 10;
    int num = 0;
    public Animator animator;
    public GameObject stool;
    int auth1 = 0;
    int auth2 = 0;
    int auth3 = 0;
    public TextMeshProUGUI textMeshPro; 
    void Start()
    {
        btn.onClick.AddListener(textFile);
        t.text = "";
        stool.SetActive(!true);
      
    }

    private void Update()
    {
        if(num==1)
        {
            animator.SetBool("work", true);
        }
        if (timers == 0)
        {
            animator.SetBool("work", !true);
            num = 0;

        }
        if(File.Exists("D:/auth/fileFound.txt")&&auth1==0)
        {
            textMeshPro.text = "FOUND VIDEO AND TRANSCRIPTING IT";
            File.Delete("D:/auth/fileFound.txt");
            files.Remove(txts.text);

        }
        if (File.Exists("D:/auth/transcription.txt") && auth2 == 0)
        {
            textMeshPro.text = "TRANSCRIPTION DONE";
            File.Delete("D:/auth/transcription.txt");


        }
        if (File.Exists("D:/auth/saved.txt") && auth3 == 0)
        {
            textMeshPro.text = "SUMMARY SAVED IN YOUR NOTEPAD";
            File.Delete("D:/auth/saved.txt");


        }
        if (File.Exists("D:/auth/error.txt") && auth3 == 0)
        {
            textMeshPro.text = "SORRY THERE IS AN ERROR WE WILL FIX IT";
            File.Delete("D:/auth/error.txt");
            File.Delete("D:/AiPath/samples.txt");

        }
    }

    void textFile()
    {
        string[] split = txts.text.Split(".");
        if (split[1].ToLower() == "mp4" || split[1].ToLower()=="wav")
        {
            stool.SetActive(true);
            files.Add(txts.text);

            Debug.Log("ok");
            File.WriteAllLines(path, files);
            num = 1;
            timers = 100;
            StartCoroutine("timer");
        }
         
        else
        {

            textMeshPro.text = "CHECK YOUR FILE EXTENSION PROPERLY";
        }
    }
    IEnumerator timer()
    {
        while (true)
        {
            
            if(num==1&&timers!=0)
            {
                
                yield return new WaitForSeconds(1);
                timers -= 1;
                t.text=timers.ToString()+"s";
                
            }
            
            else
            {
                
                //yield return new WaitForSeconds(1);
                break;
            }
        }
    }
}