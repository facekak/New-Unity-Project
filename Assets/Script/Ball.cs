using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public enum BallColor
{
      White,
      Red,
      Yellow,
      Green,
      Brown,
      Blue,
      Pink,
      Black
}
public class Ball : MonoBehaviour
{
    
    [SerializeField] private int point;
    public int Point { get { return point; } }

    [SerializeField] private BallColor ballColor;

    [SerializeField] private MeshRenderer rd;
    private void Awake()
    {
        rd = GetComponent<MeshRenderer>();
    }

    public void SetColorAndPoint(BallColor col)
    {
        switch (col)
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
