using UnityEngine;
using System.Collections;

public class CharacterMover : MonoBehaviour
{
    public float moveSpeed;
    protected Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>();
    }

	void Update()
    {
        float horizontalAxis = Input.GetAxis("Horizontal");

        animator.SetFloat("horizontalAxis", horizontalAxis);

        if (horizontalAxis != 0) {
            this.MoveHorizontal(horizontalAxis);
        }
	}

    void MoveHorizontal(float horizontalAxis)
    {
        float moveValue = horizontalAxis * moveSpeed * Time.deltaTime;
        int aproximation = 16;

        moveValue = Mathf.Round(moveValue * 1000);
        moveValue = moveValue % 625;
        moveValue = moveValue / 1000;

        moveValue = Mathf.Round(moveValue * aproximation) / aproximation;

        this.transform.position += Vector3.right * moveValue;
    }
}
