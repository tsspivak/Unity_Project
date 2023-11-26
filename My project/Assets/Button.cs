using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    bool VB = true;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(VB);
    }
    public void OnButtonClick()
    {
        if (VB)
        {
            VB = false;
            gameObject.SetActive(VB);
        }
        else
        {
            VB = true;
            gameObject.SetActive(VB);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}