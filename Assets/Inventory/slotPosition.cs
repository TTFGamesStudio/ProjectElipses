using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slotPosition : MonoBehaviour
{
    public Transform[] slots;
    [Range(0,9)]
    public int slotToTarget;
    public float sharpness = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = smoothLerp(transform.position, slots[slotToTarget].position);
        if (slotToTarget == 0 || slotToTarget == 9)
        {
            transform.localScale = smoothLerp(transform.localScale, new Vector3(0, 0, 0));
        }
        else
        {
            transform.localScale = smoothLerp(transform.localScale, new Vector3(1, 1, 1));
        }
    }

    Vector3 smoothLerp(Vector3 from, Vector3 to)
    {
        return Vector3.Lerp(from, to, 1f - Mathf.Exp(-sharpness * Time.deltaTime));
    }
}

