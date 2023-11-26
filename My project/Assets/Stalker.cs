using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Stalker : MonoBehaviour
{
    static int collision_cou = 100;
    [SerializeField]
    public TMP_Text _text;

    void OnCollisionEnter(Collision collision)
    {
        collision_cou--;
        _text.text = collision_cou.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
