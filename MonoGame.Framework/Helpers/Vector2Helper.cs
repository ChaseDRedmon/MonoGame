using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using MonoGame.Framework.Utilities;

namespace Microsoft.Xna.Framework;

public static class Vector2Helper
{
    /// <summary>
    /// Creates a new <see cref="Vector2"/> that contains the cartesian coordinates of a vector specified in barycentric coordinates and relative to 2d-triangle.
    /// </summary>
    /// <param name="value1">The first vector of 2d-triangle.</param>
    /// <param name="value2">The second vector of 2d-triangle.</param>
    /// <param name="value3">The third vector of 2d-triangle.</param>
    /// <param name="amount1">Barycentric scalar <c>b2</c> which represents a weighting factor towards second vector of 2d-triangle.</param>
    /// <param name="amount2">Barycentric scalar <c>b3</c> which represents a weighting factor towards third vector of 2d-triangle.</param>
    /// <returns>The cartesian translation of barycentric coordinates.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector2 Barycentric(Vector2 value1, Vector2 value2, Vector2 value3, float amount1, float amount2)
    {
        return new Vector2(
            MathHelper.Barycentric(value1.X, value2.X, value3.X, amount1, amount2),
            MathHelper.Barycentric(value1.Y, value2.Y, value3.Y, amount1, amount2));
    }

    /// <summary>
    /// Creates a new <see cref="Vector2"/> that contains the cartesian coordinates of a vector specified in barycentric coordinates and relative to 2d-triangle.
    /// </summary>
    /// <param name="value1">The first vector of 2d-triangle.</param>
    /// <param name="value2">The second vector of 2d-triangle.</param>
    /// <param name="value3">The third vector of 2d-triangle.</param>
    /// <param name="amount1">Barycentric scalar <c>b2</c> which represents a weighting factor towards second vector of 2d-triangle.</param>
    /// <param name="amount2">Barycentric scalar <c>b3</c> which represents a weighting factor towards third vector of 2d-triangle.</param>
    /// <param name="result">The cartesian translation of barycentric coordinates as an output parameter.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Barycentric(ref Vector2 value1, ref Vector2 value2, ref Vector2 value3, float amount1,
        float amount2, out Vector2 result)
    {
        result.X = MathHelper.Barycentric(value1.X, value2.X, value3.X, amount1, amount2);
        result.Y = MathHelper.Barycentric(value1.Y, value2.Y, value3.Y, amount1, amount2);
    }

    /// <summary>
    /// Creates a new <see cref="Vector2"/> that contains CatmullRom interpolation of the specified vectors.
    /// </summary>
    /// <param name="value1">The first vector in interpolation.</param>
    /// <param name="value2">The second vector in interpolation.</param>
    /// <param name="value3">The third vector in interpolation.</param>
    /// <param name="value4">The fourth vector in interpolation.</param>
    /// <param name="amount">Weighting factor.</param>
    /// <returns>The result of CatmullRom interpolation.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector2 CatmullRom(Vector2 value1, Vector2 value2, Vector2 value3, Vector2 value4, float amount)
    {
        return new Vector2(
            MathHelper.CatmullRom(value1.X, value2.X, value3.X, value4.X, amount),
            MathHelper.CatmullRom(value1.Y, value2.Y, value3.Y, value4.Y, amount));
    }

    /// <summary>
    /// Creates a new <see cref="Vector2"/> that contains CatmullRom interpolation of the specified vectors.
    /// </summary>
    /// <param name="value1">The first vector in interpolation.</param>
    /// <param name="value2">The second vector in interpolation.</param>
    /// <param name="value3">The third vector in interpolation.</param>
    /// <param name="value4">The fourth vector in interpolation.</param>
    /// <param name="amount">Weighting factor.</param>
    /// <param name="result">The result of CatmullRom interpolation as an output parameter.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CatmullRom(ref Vector2 value1, ref Vector2 value2, ref Vector2 value3, ref Vector2 value4,
        float amount, out Vector2 result)
    {
        result.X = MathHelper.CatmullRom(value1.X, value2.X, value3.X, value4.X, amount);
        result.Y = MathHelper.CatmullRom(value1.Y, value2.Y, value3.Y, value4.Y, amount);
    }

    /// <summary>
    /// Creates a new <see cref="Vector2"/> that contains members from another vector rounded towards positive infinity.
    /// </summary>
    /// <param name="value">Source <see cref="Vector2"/>.</param>
    /// <returns>The rounded <see cref="Vector2"/>.</returns>
    // Used in Vector2Test
    public static Vector2 Ceiling(Vector2 value)
    {
        value.X = MathF.Ceiling(value.X);
        value.Y = MathF.Ceiling(value.Y);
        return value;
    }

    /// <summary>
    /// Round the members of this <see cref="Vector2"/> towards positive infinity.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Ceiling(this ref Vector2 vector)
    {
        vector.X = MathF.Ceiling(vector.X);
        vector.Y = MathF.Ceiling(vector.X);
    }

    /// <summary>
    /// Creates a new <see cref="Vector2"/> that contains members from another vector rounded towards positive infinity.
    /// </summary>
    /// <param name="value">Source <see cref="Vector2"/>.</param>
    /// <param name="result">The rounded <see cref="Vector2"/>.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Ceiling(ref Vector2 value, out Vector2 result)
    {
        result.X = MathF.Ceiling(value.X);
        result.Y = MathF.Ceiling(value.Y);
    }

    /// <summary>
    /// Round the members of this <see cref="Vector2"/> towards negative infinity.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Floor(this ref Vector2 vector)
    {
        vector.X = MathF.Floor(vector.X);
        vector.Y = MathF.Floor(vector.X);
    }

    /// <summary>
    /// Creates a new <see cref="Vector2"/> that contains members from another vector rounded towards negative infinity.
    /// </summary>
    /// <param name="value">Source <see cref="Vector2"/>.</param>
    /// <returns>The rounded <see cref="Vector2"/>.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector2 Floor(Vector2 value)
    {
        value.X = MathF.Floor(value.X);
        value.Y = MathF.Floor(value.Y);
        return value;
    }

    /// <summary>
    /// Creates a new <see cref="Vector2"/> that contains members from another vector rounded towards negative infinity.
    /// </summary>
    /// <param name="value">Source <see cref="Vector2"/>.</param>
    /// <param name="result">The rounded <see cref="Vector2"/>.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Floor(ref Vector2 value, out Vector2 result)
    {
        result.X = MathF.Floor(value.X);
        result.Y = MathF.Floor(value.Y);
    }

    /// <summary>
    /// Creates a new <see cref="Vector2"/> that contains hermite spline interpolation.
    /// </summary>
    /// <param name="value1">The first position vector.</param>
    /// <param name="tangent1">The first tangent vector.</param>
    /// <param name="value2">The second position vector.</param>
    /// <param name="tangent2">The second tangent vector.</param>
    /// <param name="amount">Weighting factor.</param>
    /// <returns>The hermite spline interpolation vector.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector2 Hermite(Vector2 value1, Vector2 tangent1, Vector2 value2, Vector2 tangent2, float amount)
    {
        return new Vector2(MathHelper.Hermite(value1.X, tangent1.X, value2.X, tangent2.X, amount),
            MathHelper.Hermite(value1.Y, tangent1.Y, value2.Y, tangent2.Y, amount));
    }

    /// <summary>
    /// Creates a new <see cref="Vector2"/> that contains hermite spline interpolation.
    /// </summary>
    /// <param name="value1">The first position vector.</param>
    /// <param name="tangent1">The first tangent vector.</param>
    /// <param name="value2">The second position vector.</param>
    /// <param name="tangent2">The second tangent vector.</param>
    /// <param name="amount">Weighting factor.</param>
    /// <param name="result">The hermite spline interpolation vector as an output parameter.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Hermite(ref Vector2 value1, ref Vector2 tangent1, ref Vector2 value2, ref Vector2 tangent2,
        float amount, out Vector2 result)
    {
        result.X = MathHelper.Hermite(value1.X, tangent1.X, value2.X, tangent2.X, amount);
        result.Y = MathHelper.Hermite(value1.Y, tangent1.Y, value2.Y, tangent2.Y, amount);
    }

    /// <summary>
    /// Creates a new <see cref="Vector2"/> that contains linear interpolation of the specified vectors.
    /// Uses <see cref="MathHelper.LerpPrecise"/> on MathHelper for the interpolation.
    /// Less efficient but more precise compared to <see cref="Vector2.Lerp(Vector2, Vector2, float)"/>.
    /// See remarks section of <see cref="MathHelper.LerpPrecise"/> on MathHelper for more info.
    /// </summary>
    /// <param name="value1">The first vector.</param>
    /// <param name="value2">The second vector.</param>
    /// <param name="amount">Weighting value(between 0.0 and 1.0).</param>
    /// <returns>The result of linear interpolation of the specified vectors.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector2 LerpPrecise(Vector2 value1, Vector2 value2, float amount)
    {
        return new Vector2(
            MathHelper.LerpPrecise(value1.X, value2.X, amount),
            MathHelper.LerpPrecise(value1.Y, value2.Y, amount));
    }

    /// <summary>
    /// Creates a new <see cref="Vector2"/> that contains linear interpolation of the specified vectors.
    /// Uses <see cref="MathHelper.LerpPrecise"/> on MathHelper for the interpolation.
    /// Less efficient but more precise compared to <see cref="Vector2.Lerp(ref Vector2, ref Vector2, float, out Vector2)"/>.
    /// See remarks section of <see cref="MathHelper.LerpPrecise"/> on MathHelper for more info.
    /// </summary>
    /// <param name="value1">The first vector.</param>
    /// <param name="value2">The second vector.</param>
    /// <param name="amount">Weighting value(between 0.0 and 1.0).</param>
    /// <param name="result">The result of linear interpolation of the specified vectors as an output parameter.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LerpPrecise(ref Vector2 value1, ref Vector2 value2, float amount, out Vector2 result)
    {
        result.X = MathHelper.LerpPrecise(value1.X, value2.X, amount);
        result.Y = MathHelper.LerpPrecise(value1.Y, value2.Y, amount);
    }

    /// <summary>
    /// Creates a new <see cref="Vector2"/> that contains a normalized values from another vector.
    /// </summary>
    /// <param name="value">Source <see cref="Vector2"/>.</param>
    /// <param name="result">Unit vector as an output parameter.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Normalize(this ref Vector2 value)
    {
        float val = 1.0f / MathF.Sqrt(value.X * value.X + value.Y * value.Y);
        value.X *= val;
        value.Y *= val;
    }

    /// <summary>
    /// Round the members of this <see cref="Vector2"/> to the nearest integer value.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Round(this ref Vector2 vector)
    {
        vector.X = MathF.Round(vector.X);
        vector.Y = MathF.Round(vector.Y);
    }

    /// <summary>
    /// Creates a new <see cref="Vector2"/> that contains members from another vector rounded to the nearest integer value.
    /// </summary>
    /// <param name="value">Source <see cref="Vector2"/>.</param>
    /// <returns>The rounded <see cref="Vector2"/>.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector2 Round(Vector2 value)
    {
        value.X = MathF.Round(value.X);
        value.Y = MathF.Round(value.Y);
        return value;
    }

    /// <summary>
    /// Creates a new <see cref="Vector2"/> that contains members from another vector rounded to the nearest integer value.
    /// </summary>
    /// <param name="value">Source <see cref="Vector2"/>.</param>
    /// <param name="result">The rounded <see cref="Vector2"/>.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Round(ref Vector2 value, out Vector2 result)
    {
        result.X = MathF.Round(value.X);
        result.Y = MathF.Round(value.Y);
    }

    /// <summary>
    /// Creates a new <see cref="Vector2"/> that contains cubic interpolation of the specified vectors.
    /// </summary>
    /// <param name="value1">Source <see cref="Vector2"/>.</param>
    /// <param name="value2">Source <see cref="Vector2"/>.</param>
    /// <param name="amount">Weighting value.</param>
    /// <returns>Cubic interpolation of the specified vectors.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector2 SmoothStep(Vector2 value1, Vector2 value2, float amount)
    {
        return new Vector2(
            MathHelper.SmoothStep(value1.X, value2.X, amount),
            MathHelper.SmoothStep(value1.Y, value2.Y, amount));
    }

    /// <summary>
    /// Creates a new <see cref="Vector2"/> that contains cubic interpolation of the specified vectors.
    /// </summary>
    /// <param name="value1">Source <see cref="Vector2"/>.</param>
    /// <param name="value2">Source <see cref="Vector2"/>.</param>
    /// <param name="amount">Weighting value.</param>
    /// <param name="result">Cubic interpolation of the specified vectors as an output parameter.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void SmoothStep(ref Vector2 value1, ref Vector2 value2, float amount, out Vector2 result)
    {
        result.X = MathHelper.SmoothStep(value1.X, value2.X, amount);
        result.Y = MathHelper.SmoothStep(value1.Y, value2.Y, amount);
    }

    /// <summary>
    /// Gets a <see cref="Point"/> representation for this object.
    /// </summary>
    /// <returns>A <see cref="Point"/> representation for this object.</returns>
    public static Point ToPoint(this Vector2 point)
    {
        return new Point((int)point.X, (int)point.Y);
    }

    /// <summary>
    /// Apply transformation on all vectors within array of <see cref="Vector2"/> by the specified <see cref="Matrix"/> and places the results in an another array.
    /// </summary>
    /// <param name="sourceArray">Source array.</param>
    /// <param name="matrix">The transformation <see cref="Matrix"/>.</param>
    /// <param name="destinationArray">Destination array.</param>
    public static void Transform(
        Vector2[] sourceArray,
        ref Matrix4x4 matrix,
        Vector2[] destinationArray)
    {
        Transform(sourceArray, 0, ref matrix, destinationArray, 0, sourceArray.Length);
    }

    /// <summary>
    /// Apply transformation on all vectors within array of <see cref="Vector2"/> by the specified <see cref="Quaternion"/> and places the results in an another array.
    /// </summary>
    /// <param name="sourceArray">Source array.</param>
    /// <param name="rotation">The <see cref="Quaternion"/> which contains rotation transformation.</param>
    /// <param name="destinationArray">Destination array.</param>
    public static void Transform
    (
        Vector2[] sourceArray,
        ref Quaternion rotation,
        Vector2[] destinationArray
    )
    {
        Transform(sourceArray, 0, ref rotation, destinationArray, 0, sourceArray.Length);
    }

    /// <summary>
    /// Apply transformation on vectors within array of <see cref="Vector2"/> by the specified <see cref="Matrix"/> and places the results in an another array.
    /// </summary>
    /// <param name="sourceArray">Source array.</param>
    /// <param name="sourceIndex">The starting index of transformation in the source array.</param>
    /// <param name="matrix">The transformation <see cref="Matrix"/>.</param>
    /// <param name="destinationArray">Destination array.</param>
    /// <param name="destinationIndex">The starting index in the destination array, where the first <see cref="Vector2"/> should be written.</param>
    /// <param name="length">The number of vectors to be transformed.</param>
    public static void Transform(
        Vector2[] sourceArray,
        int sourceIndex,
        ref Matrix4x4 matrix,
        Vector2[] destinationArray,
        int destinationIndex,
        int length)
    {
        ArgumentNullException.ThrowIfNull(sourceArray);
        ArgumentNullException.ThrowIfNull(destinationArray);

        if (sourceArray.Length < sourceIndex + length)
            Throw.ArgumentException("Source array length is lesser than sourceIndex + length");

        if (destinationArray.Length < destinationIndex + length)
            Throw.ArgumentException("Destination array length is lesser than destinationIndex + length");

        for (int x = 0; x < length; x++)
        {
            var position = sourceArray[sourceIndex + x];
            var destination = destinationArray[destinationIndex + x];
            destination.X = position.X * matrix.M11 + position.Y * matrix.M21 + matrix.M41;
            destination.Y = position.X * matrix.M12 + position.Y * matrix.M22 + matrix.M42;
            destinationArray[destinationIndex + x] = destination;
        }
    }

    /// <summary>
    /// Apply transformation on vectors within array of <see cref="Vector2"/> by the specified <see cref="Quaternion"/> and places the results in an another array.
    /// </summary>
    /// <param name="sourceArray">Source array.</param>
    /// <param name="sourceIndex">The starting index of transformation in the source array.</param>
    /// <param name="rotation">The <see cref="Quaternion"/> which contains rotation transformation.</param>
    /// <param name="destinationArray">Destination array.</param>
    /// <param name="destinationIndex">The starting index in the destination array, where the first <see cref="Vector2"/> should be written.</param>
    /// <param name="length">The number of vectors to be transformed.</param>
    public static void Transform
    (
        Vector2[] sourceArray,
        int sourceIndex,
        ref Quaternion rotation,
        Vector2[] destinationArray,
        int destinationIndex,
        int length
    )
    {
        ArgumentNullException.ThrowIfNull(sourceArray);
        ArgumentNullException.ThrowIfNull(destinationArray);

        if (sourceArray.Length < sourceIndex + length)
            Throw.ArgumentException("Source array length is lesser than sourceIndex + length");

        if (destinationArray.Length < destinationIndex + length)
            Throw.ArgumentException("Destination array length is lesser than destinationIndex + length");

        for (int x = 0; x < length; x++)
        {
            var position = sourceArray[sourceIndex + x];
            var destination = destinationArray[destinationIndex + x];

            Vector2 v = Vector2.Transform(position, rotation);

            destination.X = v.X;
            destination.Y = v.Y;

            destinationArray[destinationIndex + x] = destination;
        }
    }

    /// <summary>
    /// Apply transformation on normals within array of <see cref="Vector2"/> by the specified <see cref="Matrix"/> and places the results in an another array.
    /// </summary>
    /// <param name="sourceArray">Source array.</param>
    /// <param name="sourceIndex">The starting index of transformation in the source array.</param>
    /// <param name="matrix">The transformation <see cref="Matrix"/>.</param>
    /// <param name="destinationArray">Destination array.</param>
    /// <param name="destinationIndex">The starting index in the destination array, where the first <see cref="Vector2"/> should be written.</param>
    /// <param name="length">The number of normals to be transformed.</param>
    public static void TransformNormal
    (
        Vector2[] sourceArray,
        int sourceIndex,
        ref Matrix4x4 matrix,
        Vector2[] destinationArray,
        int destinationIndex,
        int length
    )
    {
        ArgumentNullException.ThrowIfNull(sourceArray);
        ArgumentNullException.ThrowIfNull(destinationArray);

        if (sourceArray.Length < sourceIndex + length)
            Throw.ArgumentException("Source array length is lesser than sourceIndex + length");

        if (destinationArray.Length < destinationIndex + length)
            Throw.ArgumentException("Destination array length is lesser than destinationIndex + length");

        for (var i = 0; i < length; i++)
        {
            var normal = sourceArray[sourceIndex + i];

            destinationArray[destinationIndex + i] = new Vector2((normal.X * matrix.M11) + (normal.Y * matrix.M21),
                (normal.X * matrix.M12) + (normal.Y * matrix.M22));
        }
    }

    /// <summary>
    /// Apply transformation on all normals within array of <see cref="Vector2"/> by the specified <see cref="Matrix"/> and places the results in an another array.
    /// </summary>
    /// <param name="sourceArray">Source array.</param>
    /// <param name="matrix">The transformation <see cref="Matrix"/>.</param>
    /// <param name="destinationArray">Destination array.</param>
    public static void TransformNormal
    (
        Vector2[] sourceArray,
        ref Matrix4x4 matrix,
        Vector2[] destinationArray
    )
    {
        ArgumentNullException.ThrowIfNull(sourceArray);
        ArgumentNullException.ThrowIfNull(destinationArray);

        if (destinationArray.Length < sourceArray.Length)
            Throw.ArgumentException("Destination array length is lesser than source array length");

        for (var i = 0; i < sourceArray.Length; i++)
        {
            var normal = sourceArray[i];

            destinationArray[i] = new Vector2((normal.X * matrix.M11) + (normal.Y * matrix.M21),
                (normal.X * matrix.M12) + (normal.Y * matrix.M22));
        }
    }

    public static SharpDX.Vector2 AsSharpDXVector2(this ref Vector2 value) =>
        new(x: value.X, y: value.Y);
}
