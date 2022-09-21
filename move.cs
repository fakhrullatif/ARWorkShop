using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public GameObject maskTarget;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveUp()
    {
        maskTarget.transform.localPosition = new Vector3(maskTarget.transform.localPosition.x, maskTarget.transform.localPosition.y, maskTarget.transform.localPosition.z + 0.5f);
    }

    public void moveDown()
    {
        maskTarget.transform.localPosition = new Vector3(maskTarget.transform.localPosition.x, maskTarget.transform.localPosition.y, maskTarget.transform.localPosition.z - 0.5f);
    }

    public void moveRight()
    {
        maskTarget.transform.localPosition = new Vector3(maskTarget.transform.localPosition.x + 0.5f, maskTarget.transform.localPosition.y, maskTarget.transform.localPosition.z);
    }

    public void moveLeft()
    {
        maskTarget.transform.localPosition = new Vector3(maskTarget.transform.localPosition.x - 0.5f, maskTarget.transform.localPosition.y, maskTarget.transform.localPosition.z);
    }
}
