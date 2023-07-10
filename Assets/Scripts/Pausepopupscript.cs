using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausepopupscript : MonoBehaviour
{
    public Transform box;
    public CanvasGroup background;
    [SerializeField] GamePausePlay PausePlayScript;
    private void Awake()
    {
        gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
      

    }



    public void CloseDialog()
    {
        gameObject.SetActive(false);
      
    }
   
}
