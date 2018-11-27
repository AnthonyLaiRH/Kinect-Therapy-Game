﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HitBox : MonoBehaviour
{
    public GameObject ringPrefab;
    private GameObject noteObject;
    private bool noteIsTouching;
    public const string innerHitBoxName = "Inner(Clone)";
    public const string outerHitBoxName = "Outer(Clone)";
    public const string boundaryName = "Boundary(Clone)";


    // detects note collisions
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == Note.noteName)
        {
            noteIsTouching = true;
        }

        noteObject = col.gameObject;
    }

    // detects note exits
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name == Note.noteName)
        {
            noteIsTouching = false;
        }

        noteObject = null;
    }

    public GameObject getNoteObject()
    {
        return this.noteObject;
    }


    public bool getNoteIsTouching(){
        return this.noteIsTouching;
    }

}
