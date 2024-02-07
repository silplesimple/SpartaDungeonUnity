using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    [SerializeField]private GameObject MainGUI;
    [SerializeField]private GameObject StatusGUI;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {        
        StartGUI();
    }

    private void StartGUI()
    {
        MainGUI.SetActive(true);
        StatusGUI.SetActive(false);
    }

    public void OnStatus()
    {
        Debug.Log("스테이터스입니다");
        MainGUI.SetActive(false);
        StatusGUI.SetActive(true);
    }
}
