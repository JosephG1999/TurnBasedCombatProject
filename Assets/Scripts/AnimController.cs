using UnityEngine;

public class AnimController : MonoBehaviour
{

    public Animator eAnimator;
    void Start()
    {
        eAnimator.CrossFade("Idle", 0.0f);
    }

    void Update()
    {
        
    }
}
