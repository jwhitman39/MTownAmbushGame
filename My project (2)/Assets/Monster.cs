using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Monster : MonoBehaviour
{
    // public bool that indicates whether or not Monster is attacking
    public bool isAmbushing = false;
    // public bool that indicates whether player has countered them or not
    public bool isCountered = false;
    public GameObject monster;
    public GameObject player;
    MonsterMovement MovementLogic = null;
    Player PlayerLogic = null;
    private void Start()
    {
        MovementLogic = monster.GetComponent<MonsterMovement>();
        PlayerLogic = player.GetComponent<Player>();
        StartCoroutine(Run(1f));
        StartCoroutine(Ambush(2.3f));
    }
    private void Update()
    {
        if (isCountered)
        {
            MovementLogic.rb.constraints = RigidbodyConstraints2D.None;
            MovementLogic.horizontalInput = 20;
        }
    }
    public IEnumerator Run(float delay)
    {
        yield return new WaitForSeconds(delay);
        Debug.Log("monster now running...");
        MovementLogic.horizontalInput = -1;
    }
    public IEnumerator Ambush(float delay)
    {
        yield return new WaitForSeconds(delay);
        Debug.Log("monster now attacking!");
        MovementLogic.rb.linearVelocity = new Vector2(MovementLogic.rb.linearVelocity.x, MovementLogic.jumpPower);
        MovementLogic.animator.SetBool("isJumping", true);
        StartCoroutine(Delay(1f));
        MovementLogic.rb.constraints = RigidbodyConstraints2D.FreezePosition;
        PlayerLogic.isAmbushed = true;

    }
    public IEnumerator Delay(float delay)
    {
        yield return new WaitForSeconds(delay);
    }
}
