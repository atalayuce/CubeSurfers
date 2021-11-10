using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCube : MonoBehaviour
{
    bool isPicked;
    int index;
    public Picker picker;
    
    void Start()
    {
        isPicked = false;
    }

    
    void Update()
    {
        if (isPicked==true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            picker.HeightDecrease();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

    public bool GetIsPicked()
    {
        return isPicked;
    }
    public void Picked()
    {
        isPicked = true;
    }
    public void SetIndex(int index)
    {
        this.index = index;
    }
}
