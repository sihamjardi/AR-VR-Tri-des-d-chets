using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bin : MonoBehaviour
{
    public string binType;

    public void AcceptTrash(GameObject trash)
    {
        // Move trash inside bin and disable it
        trash.transform.position = transform.position + new Vector3(0, 0.5f, 0);
        trash.SetActive(false);
        Debug.Log($"{trash.name} correctly sorted into {binType} bin!");
    }
}
