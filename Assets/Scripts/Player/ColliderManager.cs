using System.Collections.Generic;
using UnityEngine;

public class ColliderManager : MonoBehaviour
{
    PolygonCollider2D polygonCollider2D;
    [SerializeField] List<PolygonCollider2D> polygonCollider2Ds;
    SpriteRenderer spriteRenderer;
    Animator animator;
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        polygonCollider2D = GetComponent<PolygonCollider2D>();
        animator = GetComponent<Animator>();
    }
    
    // Player Cat
    public void SetCollider1()
    {
        polygonCollider2D.SetPath(0, polygonCollider2Ds[0].points);
    }

    public void SetCollider2()
    {
        polygonCollider2D.SetPath(0, polygonCollider2Ds[1].points);
    }
    public void SetCollider3()
    {
        polygonCollider2D.SetPath(0, polygonCollider2Ds[2].points);
    }
    public void SetCollider4()
    {
        polygonCollider2D.SetPath(0, polygonCollider2Ds[3].points);
    }
    public void SetCollider5()
    {
        polygonCollider2D.SetPath(0, polygonCollider2Ds[4].points);
    }
    public void SetCollider6()
    {
        polygonCollider2D.SetPath(0, polygonCollider2Ds[5].points);
    }
    public void SetCollider7()
    {
        polygonCollider2D.SetPath(0, polygonCollider2Ds[6].points);
    }


    // Player Bird
    public void SetColliderJumpUp()
    {
        polygonCollider2D.SetPath(0, polygonCollider2Ds[2].points);
    }

    public void SetColliderJumpOn()
    {
        polygonCollider2D.SetPath(0, polygonCollider2Ds[1].points);
    }

    public void SetColliderJumpDown()
    {
        polygonCollider2D.SetPath(0, polygonCollider2Ds[0].points);
    }
}
