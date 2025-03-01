using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timetoWait = 2f;
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidBody = GetComponent<Rigidbody>();

        myMeshRenderer.enabled = false; // make the object invisible
        myRigidBody.useGravity = false; // make it not fall
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timetoWait)
        {
            myMeshRenderer.enabled = true;
            myRigidBody.useGravity = true;
        }
    }
}
