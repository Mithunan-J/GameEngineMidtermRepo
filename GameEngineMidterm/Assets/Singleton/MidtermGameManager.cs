using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MidtermGameManager : MonoBehaviour
{
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        text.GetComponent<TextMeshProUGUI>().text = "Speed " + SoundManager._instance.GetPitch().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
