using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;


public class manager : MonoBehaviour
{
    public GameObject ob;
    public Rigidbody rb;

    GameObject ob1;
    private float a;
    // Use this for initialization
    void Start()
    {

        ob = GameObject.Find("Sphere");
        rb = ob.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("aaa");
            Debug.Log("aaa");

        } //點擊滑鼠左鍵
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(new Vector3(1.0f, 1.0f, 1.0f) * 200);

        }

    }
    public void aaa(float a)
    {
        a = 1.5f;

    }

}