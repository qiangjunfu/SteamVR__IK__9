using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class TestData
{
    [SerializeField, ReadOnly] public int id;
    [SerializeField, ReadOnly] public string Name;
    [SerializeField, ReadOnly] public int Age;
    [SerializeField, ReadOnly] public string Email;
    [SerializeField, ReadOnly] public float id2;
    [SerializeField, ReadOnly] public bool isA;
    [SerializeField, ReadOnly] public int[] aa;
    [SerializeField, ReadOnly] public string[] bb;
    [SerializeField, ReadOnly] public bool[] cc;
    [SerializeField, ReadOnly] public float[] dd;


    public TestData() { }
}