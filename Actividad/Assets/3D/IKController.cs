using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations.Rigging;

public class IKController : MonoBehaviour
{
    public Slider sliderAnimation;
    public TwoBoneIKConstraint RigLeg;
    public TwoBoneIKConstraint RigLegTwo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RigLeg.weight = sliderAnimation.value;
        RigLegTwo.weight = sliderAnimation.value;
    }
}
