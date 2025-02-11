﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dialoguemanage : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public Animator anim;
    public float typingSpeed;
    public bool dStart=false;

    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Type());
    }

    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(0.02f);
        }
    }

    public void AccessNextSentence()
    {
        if(Input.GetKeyDown("z"))
        {
            NextSentence();
        }
    }

    public void NextSentence()
    {
        if(index < sentences.Length - 1)
        {
            index++;
            textDisplay.text="";
            StartCoroutine(Type());
        }
        else
        {
            anim.SetBool("dialogueStart",false);
            textDisplay.text="";
        }
    }



    // Update is called once per frame
    void Update()
    {
        AccessNextSentence();
        
    }
}
