using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;
public class TouchToJump : MonoBehaviour
{
    [SerializeField] float power;
    Rigidbody2D rb2D;
    Animator animator;
    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !IsPointerOverUIObject())
        {
            rb2D.AddForce(Vector2.up * power, ForceMode2D.Impulse);
            if (gameObject.tag == "Bird")
            {
                animator.SetTrigger("Jump");
            }
        }
    }

    bool IsPointerOverUIObject()
    {
        // Returns true if the pointer is over a UI object
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
        return results.Count > 0;
    }
}
