using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Phoenix
{
    [CreateAssetMenu(menuName ="SO/Bullet Movements/Boomerang", fileName = "BM_Boomerang")]
    public class BulletMovementBoomerang : BulletMovement
    {
        Vector2 destination;

        public override void ModifyBullet(BulletController bullet)
        {

        }



        public override void Move(BulletController bullet)
        {
            bullet.RigidBody.AddForce((bullet.BulletProperties.Speed * Time.deltaTime * (Vector2)bullet.transform.up) - bullet.RigidBody.velocity, ForceMode2D.Impulse);

        }
    }
}
