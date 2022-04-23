using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartnerAI : MonoBehaviour
{
    [SerializeField] private Transform Target;
    [SerializeField] private Transform MyTransform;
    [SerializeField] private float Range = 5f;
    [SerializeField] private float PartnerSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(Target.position, MyTransform.position) > Range)
        {
            PartnerFollow();
        }
    }

    void PartnerFollow()
    {
        transform.position = Vector2.Lerp(MyTransform.position, Target.position, Time.deltaTime * PartnerSpeed);
    }
}
