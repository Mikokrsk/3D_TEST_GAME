using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_script : MonoBehaviour
{
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        text.text = Setings_Menu_Script._run_Forward.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
