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

        public void ChangeSpeed(float increaseRate)
        {
            Debug.Log("Speed Changed by a factor of "+increaseRate);
        }

        protected override void MoveForward()
        {
            direction = (destination.x - transform.position.x > 0) ? Vector2.right : Vector2.left;
            body.AddForce(direction*moveForce);
        }
        
    }
}
