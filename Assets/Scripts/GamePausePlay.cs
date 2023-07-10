using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePausePlay : MonoBehaviour
{
    [SerializeField] Button pausebutton;
    [SerializeField] Button playbutton;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PausePlay()
    {

        //problem lies here somehow find a way to not to do it
        if(pausebutton.gameObject.activeInHierarchy==false)
        {
            pausebutton.gameObject.SetActive(true);
            playbutton.gameObject.SetActive(false);
            Time.timeScale = 0;
        }
        else
        if(playbutton.gameObject.activeInHierarchy == false)
        {
            playbutton.gameObject.SetActive(true);
            pausebutton.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }
   
}
