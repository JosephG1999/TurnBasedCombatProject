using UnityEngine;

public class AnimController : MonoBehaviour
{
    public static AnimController instance;
    public GameManager Manager;
    public Animator eAnimator, bAnimator;

    public void ejected()
    {
        bAnimator.SetTrigger("ejected");
    }
}
