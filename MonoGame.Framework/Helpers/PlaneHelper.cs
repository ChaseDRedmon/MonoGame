using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Microsoft.Xna.Framework.Helpers;

public static class PlaneHelper
{
    /// <summary>
    /// Returns a value indicating what side (positive/negative) of a plane a point is
    /// </summary>
    /// <param name="point">The point to check with</param>
    /// <param name="plane">The plane to check against</param>
    /// <returns>Greater than zero if on the positive side, less than zero if on the negative size, 0 otherwise</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float ClassifyPoint(this ref Plane plane, ref Vector3 point)
    {
        return point.X * plane.Normal.X + point.Y * plane.Normal.Y + point.Z * plane.Normal.Z + plane.D;
    }

    /// <summary>
    /// Get the dot product of a <see cref="Vector3"/> with
    /// the <see cref="Normal"/> vector of this <see cref="Plane"/>
    /// plus the <see cref="D"/> value of this <see cref="Plane"/>.
    /// </summary>
    /// <param name="value">The <see cref="Vector3"/> to calculate the dot product with.</param>
    /// <param name="result">
    /// The dot product of the specified <see cref="Vector3"/> and the normal of this <see cref="Plane"/>
    /// plus the <see cref="D"/> value of this <see cref="Plane"/>.
    /// </param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float DotCoordinate(this ref Plane plane, ref Vector3 value, float D)
    {
        return plane.Normal.X * value.X +
               plane.Normal.Y * value.Y +
               plane.Normal.Z * value.Z + D;
    }

    /// <summary>
    /// Get the dot product of a <see cref="Vector4"/> with this <see cref="Plane"/>.
    /// </summary>
    /// <param name="value">The <see cref="Vector4"/> to calculate the dot product with.</param>
    /// <returns>The dot product of the specified <see cref="Vector4"/> and this <see cref="Plane"/>.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Dot(this ref Plane plane, ref Vector4 value)
    {
        return plane.Normal.X * value.X +
               plane.Normal.Y * value.Y +
               plane.Normal.Z * value.Z +
               plane.D * value.W;
    }

    /// <summary>
    /// Get the dot product of a <see cref="Vector4"/> with this <see cref="Plane"/>.
    /// </summary>
    /// <param name="value">The <see cref="Vector4"/> to calculate the dot product with.</param>
    /// <param name="result">
    /// The dot product of the specified <see cref="Vector4"/> and this <see cref="Plane"/>.
    /// </param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Dot(this ref Plane plane, ref Vector4 value, out float result)
    {
        result = plane.Normal.X * value.X +
                 plane.Normal.Y * value.Y +
                 plane.Normal.Z * value.Z +
                 plane.D * value.W;
    }

    /// <summary>
    /// Check if this <see cref="Plane"/> intersects a <see cref="BoundingBox"/>.
    /// </summary>
    /// <param name="box">The <see cref="BoundingBox"/> to test for intersection.</param>
    /// <returns>
    /// The type of intersection of this <see cref="Plane"/> with the specified <see cref="BoundingBox"/>.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static PlaneIntersectionType Intersects(this ref Plane plane, BoundingBox box)
    {
        return box.Intersects(plane);
    }

    /// <summary>
    /// Check if this <see cref="Plane"/> intersects a <see cref="BoundingBox"/>.
    /// </summary>
    /// <param name="box">The <see cref="BoundingBox"/> to test for intersection.</param>
    /// <param name="result">
    /// The type of intersection of this <see cref="Plane"/> with the specified <see cref="BoundingBox"/>.
    /// </param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Intersects(this ref Plane plane, ref BoundingBox box, out PlaneIntersectionType result)
    {
        box.Intersects(ref plane, out result);
    }

    /// <summary>
    /// Check if this <see cref="Plane"/> intersects a <see cref="BoundingFrustum"/>.
    /// </summary>
    /// <param name="frustum">The <see cref="BoundingFrustum"/> to test for intersection.</param>
    /// <returns>
    /// The type of intersection of this <see cref="Plane"/> with the specified <see cref="BoundingFrustum"/>.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static PlaneIntersectionType Intersects(this ref Plane plane, BoundingFrustum frustum)
    {
        return frustum.Intersects(plane);
    }

    /// <summary>
    /// Check if this <see cref="Plane"/> intersects a <see cref="BoundingSphere"/>.
    /// </summary>
    /// <param name="sphere">The <see cref="BoundingSphere"/> to test for intersection.</param>
    /// <returns>
    /// The type of intersection of this <see cref="Plane"/> with the specified <see cref="BoundingSphere"/>.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static PlaneIntersectionType Intersects(this ref Plane plane, BoundingSphere sphere)
    {
        return sphere.Intersects(plane);
    }

    /// <summary>
    /// Check if this <see cref="Plane"/> intersects a <see cref="BoundingSphere"/>.
    /// </summary>
    /// <param name="sphere">The <see cref="BoundingSphere"/> to test for intersection.</param>
    /// <param name="result">
    /// The type of intersection of this <see cref="Plane"/> with the specified <see cref="BoundingSphere"/>.
    /// </param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Intersects(this ref Plane plane, ref BoundingSphere sphere, out PlaneIntersectionType result)
    {
        sphere.Intersects(ref plane, out result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static PlaneIntersectionType Intersects(this ref Plane plane, ref Vector3 point)
    {
        var distance = Vector3.Dot(plane.Normal, point);

        return distance switch
        {
            > 0 => PlaneIntersectionType.Front,
            < 0 => PlaneIntersectionType.Back,
            _ => PlaneIntersectionType.Intersecting
        };
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static PlaneIntersectionType Intersects(this ref Plane plane, ref Vector3 point, float D)
    {
        var distance = DotCoordinate(ref plane, ref point, D);

        return distance switch
        {
            > 0 => PlaneIntersectionType.Front,
            < 0 => PlaneIntersectionType.Back,
            _ => PlaneIntersectionType.Intersecting
        };
    }

    /// <summary>
    /// Returns the perpendicular distance from a point to a plane
    /// </summary>
    /// <param name="point">The point to check</param>
    /// <param name="plane">The place to check</param>
    /// <returns>The perpendicular distance from the point to the plane</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float PerpendicularDistance(ref Vector3 point, ref Plane plane)
    {
        if (Vector.IsHardwareAccelerated)
        {
            // dist = (ax + by + cz + d) / sqrt(a*a + b*b + c*c)
            var normal = new Vector3(plane.Normal.X, plane.Normal.Y, plane.Normal.Z);
            return Math.Abs(Vector3.Dot(normal, point) / normal.Length());
        }

        // dist = (ax + by + cz + d) / sqrt(a*a + b*b + c*c)
        return (float)Math.Abs((plane.Normal.X * point.X + plane.Normal.Y * point.Y + plane.Normal.Z * point.Z)
                               / Math.Sqrt(plane.Normal.X * plane.Normal.X + plane.Normal.Y * plane.Normal.Y +
                                           plane.Normal.Z * plane.Normal.Z));
    }
}
