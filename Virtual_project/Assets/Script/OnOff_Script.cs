using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOff_Script : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject onoff;
    public KeyCode input;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(input))
        {
            onoff.SetActive(!onoff.activeSelf);
        }
    }
}
