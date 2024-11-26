using UnityEngine;

public class SlowAnimation : MonoBehaviour
{
    public Animator animator;
    public float speedFactor = 0.5f;  // 1.0 is normal speed, < 1 is slower

    void Start()
    {
        if (animator == null)
            animator = GetComponent<Animator>();
        
        animator.speed = speedFactor;  // Slow down all animations
    }
}
