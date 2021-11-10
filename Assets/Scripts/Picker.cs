using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picker : MonoBehaviour
{
    GameObject mainCube;
    int heigh;
    void Start()
    {
        mainCube = GameObject.Find("MainCube");
    }

    void Update()
    {
        mainCube.transform.position = new Vector3(transform.position.x, heigh + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -heigh, 0);
    }
    public void HeightDecrease()
    {
        heigh--;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pick" && other.gameObject.GetComponent<CollectableCube>().GetIsPicked() == false)
            
        {
            heigh += 1;
            other.gameObject.GetComponent<CollectableCube>().Picked();
            other.gameObject.GetComponent<CollectableCube>().SetIndex(heigh);
            other.gameObject.transform.parent = mainCube.transform;

        }
    }
}
