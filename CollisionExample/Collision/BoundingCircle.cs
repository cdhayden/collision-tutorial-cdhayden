using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CollisionExample.Collision
{
    /// <summary>
    /// Struct to represent circular bounds
    /// </summary>
    public struct BoundingCircle
    {
        /// <summary>
        /// vector to represent the center of the circle
        /// </summary>
        public Vector2 Center;

        /// <summary>
        /// float to represent the radius of the circle
        /// </summary>
        public float Radius;

        /// <summary>
        /// Constructs a new BoundingCircle
        /// </summary>
        /// <param name="center">the center of the circle</param>
        /// <param name="radius">the radius of the circle</param>
        public BoundingCircle(Vector2 center, float radius) 
        {
            Center = center;
            Radius = radius;
        }

        /// <summary>
        /// determines collision between this circle and another
        /// </summary>
        /// <param name="other">the other circle</param>
        /// <returns>true for collision, false otherwise</returns>
        public bool CollidesWith(BoundingCircle other) 
        {
            return CollisionHelper.Collides(this, other);
        }

        /// <summary>
        /// determines collision between this circle and a rectangle
        /// </summary>
        /// <param name="other">the rectangle</param>
        /// <returns>true for collision, false otherwise</returns>
        public bool CollidesWith(BoundingRectangle other)
        {
            return CollisionHelper.Collides(this, other);
        }
    }
}
