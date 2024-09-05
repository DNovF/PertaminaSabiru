using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class alphavideo : MonoBehaviour
{

    public RawImage rawImg = null;
    public byte alpha = 255;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Color color;
        color = new Color32(0, 0, 0, alpha);
        if (rawImg) rawImg.color = new Color(rawImg.color.r, rawImg.color.g, rawImg.color.b, color.a);
    }
}
