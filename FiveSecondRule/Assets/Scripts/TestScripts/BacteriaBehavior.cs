using System;
using UnityEngine;

namespace TestScripts
{
    public class BacteriaBehavior : BaseGermBehavior
    {
        
        protected override void Start()
        {
            base.Start();
        }
   

        public override void Evolve()
        {
            Debug.Log("Hardened");
        }

        protected override void MoveForward()
        {
            direction = (destination.x - transform.position.x > 0) ? Vector2.right : Vector2.left;
            body.AddForce(direction*moveForce);
            Debug.Log("moved"+direction);
        }
    }
}
