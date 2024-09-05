using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveButton : MonoBehaviour
{
    public bool isActive;
    [SerializeField]
    Sprite[] imageSet;

    [SerializeField]
    Image imgSet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            imgSet.sprite = imageSet[1];
        }
        else
        {
            imgSet.sprite = imageSet[0];

        }
    }
}
