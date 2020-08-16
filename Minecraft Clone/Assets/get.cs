using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class get : MonoBehaviour
{
    public GameObject UI;
    public GameObject CubePrefab;
    public GameObject camera_static;
    public GameObject camera_FPS;

    public int N;
    void Start()
    {
        camera_FPS.SetActive(false);
        camera_static.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        Text PlaceHolder = UI.transform.GetComponent<InputField>().placeholder.GetComponent<Text>();

        if (PlaceHolder == null)
            return;
            
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            N = int.Parse(UI.transform.GetComponent<InputField>().text.ToString());
            //Debug.Log(N);
            UI.SetActive(false);
            camera_static.SetActive(false);
            camera_FPS.SetActive(true);
        }
    }
}
