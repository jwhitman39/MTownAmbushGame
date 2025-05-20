using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private HealthBarUI healthBar;
    [SerializeField]
    private PushbackBarUI pushbackBar;
    // public bool indicating whether player is being attacked or not
    public bool isAmbushed = false;
    public bool underAttack = false;
    public float Health, MaxHealth, Pushback, MaxPushback;
    public Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        healthBar.SetHealth(MaxHealth);
        pushbackBar.SetMaxPushback(MaxPushback);
    }
    private void Update()
    {
        if (isAmbushed && !underAttack)
        {
            animator.SetBool("isAmbushed", true);
            underAttack = true;
        }
        if (!isAmbushed && underAttack)
        {
            animator.SetBool("isAmbushed", false);
            underAttack = false;
        }
    }
    public void SetHealth(float healthChange)
    {
        Health += healthChange;
        Health = Mathf.Clamp(Health, 0, MaxHealth);

        healthBar.SetHealth(Health);
    }
    public void SetPushback(float pushbackChange)
    {
        Pushback += pushbackChange;
        Pushback = Mathf.Clamp(Pushback, 0, MaxPushback);

        pushbackBar.SetPushback(Pushback);
    }
}
