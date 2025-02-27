using UnityEngine;

public class Mover : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        float xValue = Input.GetAxis("Horizontal"); // moving left and right 
        float yValue = 0f;  // moving up and down
        float zValue = Input.GetAxis("Vertical"); // moving to the screen
        transform.Translate(xValue, yValue, zValue);
    }
}
