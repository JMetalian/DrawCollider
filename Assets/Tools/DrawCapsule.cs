using UnityEngine;


namespace Game.Tools
{
    public class DrawCapsule
    {
        /// <summary>
        /// 	- Draws a capsule collider gizmo with wired sphere and lines.
        /// </summary>
        /// <param name='offset'>
        /// 	- The position of desired capsule collider2D in run time.
        /// </param>
        /// <param name='size'>
        /// 	- The size of esired capsule collider2D in run time.
        /// </param>
        public static void Draw2DCapsule(Vector2 offset, Vector2 size)
        {
            //Central sphere.
            Gizmos.DrawWireSphere(offset, size.x * 0.5f);
            //Upper sphere.
            Gizmos.DrawWireSphere(offset + (Vector2.up * size.y * 0.345f), size.x * 0.5f);
            //Botton sphere
            Gizmos.DrawWireSphere(offset - (Vector2.up * size.y * 0.345f), size.x * 0.5f);
            //Left and right edges.
            Gizmos.DrawLine(offset + (Vector2.up * size.y * 0.345f) + Vector2.right * size.x * 0.5f, offset - (Vector2.up * size.y * 0.345f) + Vector2.right * size.x * 0.5f);
            Gizmos.DrawLine(offset + (Vector2.up * size.y * 0.345f) - Vector2.right * size.x * 0.5f, offset - (Vector2.up * size.y * 0.345f) - Vector2.right * size.x * 0.5f);

            // 0.345f is a tuning value for exact matching with real CapsuleCollider2D.
        }
    }
}
