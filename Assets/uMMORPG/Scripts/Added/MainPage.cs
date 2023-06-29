using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPage : MonoBehaviour
{
    //public GameObject nextPage;
    public NetworkManagerMMO manager; // singleton=null in Start/Awake

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenSelectHeroPage()
    {
        this.gameObject.SetActive(false);
        manager.StartHost();
        //nextPage.SetActive(true);
    }
}
