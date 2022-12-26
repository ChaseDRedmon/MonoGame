using System;
using System.Numerics;
using MonoGame.Framework.Utilities;

namespace Microsoft.Xna.Framework;

public static class Vector3Helper
{
    public static Vector3 Up { get; } = new(0f, 1f, 0f);
    public static Vector3 Down { get; } = new(0f, -1f, 0f);
    public static Vector3 Right { get; } = new(1f, 0f, 0f);
    public static Vector3 Left { get; } = new(-1f, 0f, 0f);
    public static Vector3 Forward { get; } = new(0f, 0f, -1f);
    public static Vector3 Backward { get; } = new(0f, 0f, 1f);

    /// <summary>
    /// Creates a new <see cref="Vector3"/> that contains the cartesian coordinates of a vector specified in barycentric coordinates and relative to 3d-triangle.
    /// </summary>
    /// <param name="value1">The first vector of 3d-triangle.</param>
    /// <param name="value2">The second vector of 3d-triangle.</param>
    /// <param name="value3">The third vector of 3d-triangle.</param>
    /// <param name="amount1">Barycentric scalar <c>b2</c> which represents a weighting factor towards second vector of 3d-triangle.</param>
    /// <param name="amount2">Barycentric scalar <c>b3</c> which represents a weighting factor towards third vector of 3d-triangle.</param>
    /// <returns>The cartesian translation of barycentric coordinates.</returns>
    public static Vector3 Barycentric(Vector3 value1, Vector3 value2, Vector3 value3, float amount1, float amount2)
    {
        return new Vector3(
            MathHelper.Barycentric(value1.X, value2.X, value3.X, amount1, amount2),
            MathHelper.Barycentric(value1.Y, value2.Y, value3.Y, amount1, amount2),
            MathHelper.Barycentric(value1.Z, value2.Z, value3.Z, amount1, amount2));
    }

    /// <summary>
    /// Creates a new <see cref="Vector3"/> that contains the cartesian coordinates of a vector specified in barycentric coordinates and relative to 3d-triangle.
    /// </summary>
    /// <param name="value1">The first vector of 3d-triangle.</param>
    /// <param name="value2">The second vector of 3d-triangle.</param>
    /// <param name="value3">The third vector of 3d-triangle.</param>
    /// <param name="amount1">Barycentric scalar <c>b2</c> which represents a weighting factor towards second vector of 3d-triangle.</param>
    /// <param name="amount2">Barycentric scalar <c>b3</c> which represents a weighting factor towards third vector of 3d-triangle.</param>
    /// <param name="result">The cartesian translation of barycentric coordinates as an output parameter.</param>
    public static void Barycentric(ref Vector3 value1, ref Vector3 value2, ref Vector3 value3, float amount1,
        float amount2, out Vector3 result)
    {
        result.X = MathHelper.Barycentric(value1.X, value2.X, value3.X, amount1, amount2);
        result.Y = MathHelper.Barycentric(value1.Y, value2.Y, value3.Y, amount1, amount2);
        result.Z = MathHelper.Barycentric(value1.Z, value2.Z, value3.Z, amount1, amount2);
    }

    /// <summary>
    /// Creates a new <see cref="Vector3"/> that contains CatmullRom interpolation of the specified vectors.
    /// </summary>
    /// <param name="value1">The first vector in interpolation.</param>
    /// <param name="value2">The second vector in interpolation.</param>
    /// <param name="value3">The third vector in interpolation.</param>
    /// <param name="value4">The fourth vector in interpolation.</param>
    /// <param name="amount">Weighting factor.</param>
    /// <returns>The result of CatmullRom interpolation.</returns>
    public static Vector3 CatmullRom(Vector3 value1, Vector3 value2, Vector3 value3, Vector3 value4, float amount)
    {
        return new Vector3(
            MathHelper.CatmullRom(value1.X, value2.X, value3.X, value4.X, amount),
            MathHelper.CatmullRom(value1.Y, value2.Y, value3.Y, value4.Y, amount),
            MathHelper.CatmullRom(value1.Z, value2.Z, value3.Z, value4.Z, amount));
    }

    /// <summary>
    /// Creates a new <see cref="Vector3"/> that contains CatmullRom interpolation of the specified vectors.
    /// </summary>
    /// <param name="value1">The first vector in interpolation.</param>
    /// <param name="value2">The second vector in interpolation.</param>
    /// <param name="value3">The third vector in interpolation.</param>
    /// <param name="value4">The fourth vector in interpolation.</param>
    /// <param name="amount">Weighting factor.</param>
    /// <param name="result">The result of CatmullRom interpolation as an output parameter.</param>
    public static void CatmullRom(ref Vector3 value1, ref Vector3 value2, ref Vector3 value3, ref Vector3 value4,
        float amount, out Vector3 result)
    {
        result.X = MathHelper.CatmullRom(value1.X, value2.X, value3.X, value4.X, amount);
        result.Y = MathHelper.CatmullRom(value1.Y, value2.Y, value3.Y, value4.Y, amount);
        result.Z = MathHelper.CatmullRom(value1.Z, value2.Z, value3.Z, value4.Z, amount);
    }

    /// <summary>
    /// Creates a new <see cref="Vector3"/> that contains members from another vector rounded towards positive infinity.
    /// </summary>
    /// <param name="value">Source <see cref="Vector3"/>.</param>
    /// <returns>The rounded <see cref="Vector3"/>.</returns>
    public static Vector3 Ceiling(this Vector3 value)
    {
        return new Vector3(
            MathF.Ceiling(value.X),
            MathF.Ceiling(value.Y),
            MathF.Ceiling(value.Z));
    }

    /// <summary>
    /// Creates a new <see cref="Vector3"/> that contains members from another vector rounded towards positive infinity.
    /// </summary>
    /// <param name="value">Source <see cref="Vector3"/>.</param>
    /// <param name="result">The rounded <see cref="Vector3"/>.</param>
    public static void Ceiling(this ref Vector3 value, out Vector3 result)
    {
        result.X = MathF.Ceiling(value.X);
        result.Y = MathF.Ceiling(value.Y);
        result.Z = MathF.Ceiling(value.Z);
    }

    /// <summary>
    /// Round the members of this <see cref="Vector3"/> towards negative infinity.
    /// </summary>
    public static void Floor(this ref Vector3 vector)
    {
        vector.X = MathF.Floor(vector.X);
        vector.Y = MathF.Floor(vector.Y);
        vector.Z = MathF.Floor(vector.Z);
    }

    /// <summary>
    /// Creates a new <see cref="Vector3"/> that contains members from another vector rounded towards negative infinity.
    /// </summary>
    /// <param name="value">Source <see cref="Vector3"/>.</param>
    /// <returns>The rounded <see cref="Vector3"/>.</returns>
    public static Vector3 Floor(Vector3 value)
    {
        value.X = MathF.Floor(value.X);
        value.Y = MathF.Floor(value.Y);
        value.Z = MathF.Floor(value.Z);
        return value;
    }

    /// <summary>
    /// Creates a new <see cref="Vector3"/> that contains members from another vector rounded towards negative infinity.
    /// </summary>
    /// <param name="value">Source <see cref="Vector3"/>.</param>
    /// <param name="result">The rounded <see cref="Vector3"/>.</param>
    public static void Floor(ref Vector3 value, out Vector3 result)
    {
        result.X = MathF.Floor(value.X);
        result.Y = MathF.Floor(value.Y);
        result.Z = MathF.Floor(value.Z);
    }

    /// <summary>
    /// Creates a new <see cref="Vector3"/> that contains hermite spline interpolation.
    /// </summary>
    /// <param name="value1">The first position vector.</param>
    /// <param name="tangent1">The first tangent vector.</param>
    /// <param name="value2">The second position vector.</param>
    /// <param name="tangent2">The second tangent vector.</param>
    /// <param name="amount">Weighting factor.</param>
    /// <returns>The hermite spline interpolation vector.</returns>
    public static Vector3 Hermite(Vector3 value1, Vector3 tangent1, Vector3 value2, Vector3 tangent2, float amount)
    {
        return new Vector3(MathHelper.Hermite(value1.X, tangent1.X, value2.X, tangent2.X, amount),
            MathHelper.Hermite(value1.Y, tangent1.Y, value2.Y, tangent2.Y, amount),
            MathHelper.Hermite(value1.Z, tangent1.Z, value2.Z, tangent2.Z, amount));
    }

    /// <summary>
    /// Creates a new <see cref="Vector3"/> that contains hermite spline interpolation.
    /// </summary>
    /// <param name="value1">The first position vector.</param>
    /// <param name="tangent1">The first tangent vector.</param>
    /// <param name="value2">The second position vector.</param>
    /// <param name="tangent2">The second tangent vector.</param>
    /// <param name="amount">Weighting factor.</param>
    /// <param name="result">The hermite spline interpolation vector as an output parameter.</param>
    public static void Hermite(ref Vector3 value1, ref Vector3 tangent1, ref Vector3 value2, ref Vector3 tangent2,
        float amount, out Vector3 result)
    {
        result.X = MathHelper.Hermite(value1.X, tangent1.X, value2.X, tangent2.X, amount);
        result.Y = MathHelper.Hermite(value1.Y, tangent1.Y, value2.Y, tangent2.Y, amount);
        result.Z = MathHelper.Hermite(value1.Z, tangent1.Z, value2.Z, tangent2.Z, amount);
    }

    /// <summary>
    /// Creates a new <see cref="Vector3"/> that contains linear interpolation of the specified vectors.
    /// Uses <see cref="MathHelper.LerpPrecise"/> on MathHelper for the interpolation.
    /// Less efficient but more precise compared to <see cref="Vector3.Lerp(Vector3, Vector3, float)"/>.
    /// See remarks section of <see cref="MathHelper.LerpPrecise"/> on MathHelper for more info.
    /// </summary>
    /// <param name="value1">The first vector.</param>
    /// <param name="value2">The second vector.</param>
    /// <param name="amount">Weighting value(between 0.0 and 1.0).</param>
    /// <returns>The result of linear interpolation of the specified vectors.</returns>
    public static Vector3 LerpPrecise(Vector3 value1, Vector3 value2, float amount)
    {
        return new Vector3(
            MathHelper.LerpPrecise(value1.X, value2.X, amount),
            MathHelper.LerpPrecise(value1.Y, value2.Y, amount),
            MathHelper.LerpPrecise(value1.Z, value2.Z, amount));
    }

    /// <summary>
    /// Creates a new <see cref="Vector3"/> that contains linear interpolation of the specified vectors.
    /// Uses <see cref="MathHelper.LerpPrecise"/> on MathHelper for the interpolation.
    /// Less efficient but more precise compared to <see cref="Vector3.Lerp(ref Vector3, ref Vector3, float, out Vector3)"/>.
    /// See remarks section of <see cref="MathHelper.LerpPrecise"/> on MathHelper for more info.
    /// </summary>
    /// <param name="value1">The first vector.</param>
    /// <param name="value2">The second vector.</param>
    /// <param name="amount">Weighting value(between 0.0 and 1.0).</param>
    /// <param name="result">The result of linear interpolation of the specified vectors as an output parameter.</param>
    public static void LerpPrecise(ref Vector3 value1, ref Vector3 value2, float amount, out Vector3 result)
    {
        result.X = MathHelper.LerpPrecise(value1.X, value2.X, amount);
        result.Y = MathHelper.LerpPrecise(value1.Y, value2.Y, amount);
        result.Z = MathHelper.LerpPrecise(value1.Z, value2.Z, amount);
    }

    /// <summary>
    /// Round the members of this <see cref="Vector3"/> towards the nearest integer value.
    /// </summary>
    public static void Round(this ref Vector3 vector)
    {
        vector.X = MathF.Round(vector.X);
        vector.Y = MathF.Round(vector.Y);
        vector.Z = MathF.Round(vector.Z);
    }

    /// <summary>
    /// Creates a new <see cref="Vector3"/> that contains members from another vector rounded to the nearest integer value.
    /// </summary>
    /// <param name="value">Source <see cref="Vector3"/>.</param>
    /// <returns>The rounded <see cref="Vector3"/>.</returns>
    public static Vector3 Round(Vector3 value)
    {
        value.X = MathF.Round(value.X);
        value.Y = MathF.Round(value.Y);
        value.Z = MathF.Round(value.Z);
        return value;
    }

    /// <summary>
    /// Creates a new <see cref="Vector3"/> that contains members from another vector rounded to the nearest integer value.
    /// </summary>
    /// <param name="value">Source <see cref="Vector3"/>.</param>
    /// <param name="result">The rounded <see cref="Vector3"/>.</param>
    public static void Round(ref Vector3 value, out Vector3 result)
    {
        result.X = MathF.Round(value.X);
        result.Y = MathF.Round(value.Y);
        result.Z = MathF.Round(value.Z);
    }

    /// <summary>
    /// Creates a new <see cref="Vector3"/> that contains cubic interpolation of the specified vectors.
    /// </summary>
    /// <param name="value1">Source <see cref="Vector3"/>.</param>
    /// <param name="value2">Source <see cref="Vector3"/>.</param>
    /// <param name="amount">Weighting value.</param>
    /// <returns>Cubic interpolation of the specified vectors.</returns>
    public static Vector3 SmoothStep(Vector3 value1, Vector3 value2, float amount)
    {
        return new Vector3(
            MathHelper.SmoothStep(value1.X, value2.X, amount),
            MathHelper.SmoothStep(value1.Y, value2.Y, amount),
            MathHelper.SmoothStep(value1.Z, value2.Z, amount));
    }

    /// <summary>
    /// Creates a new <see cref="Vector3"/> that contains cubic interpolation of the specified vectors.
    /// </summary>
    /// <param name="value1">Source <see cref="Vector3"/>.</param>
    /// <param name="value2">Source <see cref="Vector3"/>.</param>
    /// <param name="amount">Weighting value.</param>
    /// <param name="result">Cubic interpolation of the specified vectors as an output parameter.</param>
    public static void SmoothStep(ref Vector3 value1, ref Vector3 value2, float amount, out Vector3 result)
    {
        result.X = MathHelper.SmoothStep(value1.X, value2.X, amount);
        result.Y = MathHelper.SmoothStep(value1.Y, value2.Y, amount);
        result.Z = MathHelper.SmoothStep(value1.Z, value2.Z, amount);
    }

    /// <summary>
    /// Apply transformation on vectors within array of <see cref="Vector3"/> by the specified <see cref="Matrix"/> and places the results in an another array.
    /// </summary>
    /// <param name="sourceArray">Source array.</param>
    /// <param name="sourceIndex">The starting index of transformation in the source array.</param>
    /// <param name="matrix">The transformation <see cref="Matrix"/>.</param>
    /// <param name="destinationArray">Destination array.</param>
    /// <param name="destinationIndex">The starting index in the destination array, where the first <see cref="Vector3"/> should be written.</param>
    /// <param name="length">The number of vectors to be transformed.</param>
    public static void Transform(Vector3[] sourceArray, int sourceIndex, ref Matrix4x4 matrix,
        Vector3[] destinationArray, int destinationIndex, int length)
    {
        ArgumentNullException.ThrowIfNull(sourceArray);
        ArgumentNullException.ThrowIfNull(destinationArray);

        if (sourceArray.Length < sourceIndex + length)
            Throw.ArgumentException("Source array length is lesser than sourceIndex + length");

        if (destinationArray.Length < destinationIndex + length)
            Throw.ArgumentException("Destination array length is lesser than destinationIndex + length");

        for (var i = 0; i < length; i++)
        {
            destinationArray[destinationIndex + i] = Vector3.Transform(sourceArray[sourceIndex + i], matrix);
        }
    }

    /// <summary>
    /// Apply transformation on vectors within array of <see cref="Vector3"/> by the specified <see cref="Quaternion"/> and places the results in an another array.
    /// </summary>
    /// <param name="sourceArray">Source array.</param>
    /// <param name="sourceIndex">The starting index of transformation in the source array.</param>
    /// <param name="rotation">The <see cref="Quaternion"/> which contains rotation transformation.</param>
    /// <param name="destinationArray">Destination array.</param>
    /// <param name="destinationIndex">The starting index in the destination array, where the first <see cref="Vector3"/> should be written.</param>
    /// <param name="length">The number of vectors to be transformed.</param>
    public static void Transform(Vector3[] sourceArray, int sourceIndex, ref Quaternion rotation,
        Vector3[] destinationArray, int destinationIndex, int length)
    {
        ArgumentNullException.ThrowIfNull(sourceArray);
        ArgumentNullException.ThrowIfNull(destinationArray);

        if (sourceArray.Length < sourceIndex + length)
            Throw.ArgumentException("Source array length is lesser than sourceIndex + length");

        if (destinationArray.Length < destinationIndex + length)
            Throw.ArgumentException("Destination array length is lesser than destinationIndex + length");

        // TODO: Are there options on some platforms to implement a vectorized version of this?

        for (var i = 0; i < length; i++)
        {
            var position = sourceArray[sourceIndex + i];

            float x = 2 * (rotation.Y * position.Z - rotation.Z * position.Y);
            float y = 2 * (rotation.Z * position.X - rotation.X * position.Z);
            float z = 2 * (rotation.X * position.Y - rotation.Y * position.X);

            destinationArray[destinationIndex + i] =
                new Vector3(
                    position.X + x * rotation.W + (rotation.Y * z - rotation.Z * y),
                    position.Y + y * rotation.W + (rotation.Z * x - rotation.X * z),
                    position.Z + z * rotation.W + (rotation.X * y - rotation.Y * x));
        }
    }

    /// <summary>
    /// Apply transformation on all vectors within array of <see cref="Vector3"/> by the specified <see cref="Matrix"/> and places the results in an another array.
    /// </summary>
    /// <param name="sourceArray">Source array.</param>
    /// <param name="matrix">The transformation <see cref="Matrix"/>.</param>
    /// <param name="destinationArray">Destination array.</param>
    public static void Transform(Vector3[] sourceArray, ref Matrix4x4 matrix, Vector3[] destinationArray)
    {
        ArgumentNullException.ThrowIfNull(sourceArray);
        ArgumentNullException.ThrowIfNull(destinationArray);

        if (destinationArray.Length < sourceArray.Length)
            Throw.ArgumentException("Destination array length is lesser than source array length");

        // TODO: Are there options on some platforms to implement a vectorized version of this?

        for (var i = 0; i < sourceArray.Length; i++)
        {
            var position = sourceArray[i];
            destinationArray[i] =
                new Vector3(
                    position.X * matrix.M11 + position.Y * matrix.M21 + position.Z * matrix.M31 + matrix.M41,
                    position.X * matrix.M12 + position.Y * matrix.M22 + position.Z * matrix.M32 + matrix.M42,
                    position.X * matrix.M13 + position.Y * matrix.M23 + position.Z * matrix.M33 + matrix.M43);
        }
    }

    /// <summary>
    /// Apply transformation on all vectors within array of <see cref="Vector3"/> by the specified <see cref="Quaternion"/> and places the results in an another array.
    /// </summary>
    /// <param name="sourceArray">Source array.</param>
    /// <param name="rotation">The <see cref="Quaternion"/> which contains rotation transformation.</param>
    /// <param name="destinationArray">Destination array.</param>
    public static void Transform(Vector3[] sourceArray, ref Quaternion rotation, Vector3[] destinationArray)
    {
        ArgumentNullException.ThrowIfNull(sourceArray);
        ArgumentNullException.ThrowIfNull(destinationArray);

        if (destinationArray.Length < sourceArray.Length)
            Throw.ArgumentException("Destination array length is lesser than source array length");

        // TODO: Are there options on some platforms to implement a vectorized version of this?

        for (var i = 0; i < sourceArray.Length; i++)
        {
            var position = sourceArray[i];

            float x = 2 * (rotation.Y * position.Z - rotation.Z * position.Y);
            float y = 2 * (rotation.Z * position.X - rotation.X * position.Z);
            float z = 2 * (rotation.X * position.Y - rotation.Y * position.X);

            destinationArray[i] =
                new Vector3(
                    position.X + x * rotation.W + (rotation.Y * z - rotation.Z * y),
                    position.Y + y * rotation.W + (rotation.Z * x - rotation.X * z),
                    position.Z + z * rotation.W + (rotation.X * y - rotation.Y * x));
        }
    }

    /// <summary>
    /// Apply transformation on normals within array of <see cref="Vector3"/> by the specified <see cref="Matrix"/> and places the results in an another array.
    /// </summary>
    /// <param name="sourceArray">Source array.</param>
    /// <param name="sourceIndex">The starting index of transformation in the source array.</param>
    /// <param name="matrix">The transformation <see cref="Matrix"/>.</param>
    /// <param name="destinationArray">Destination array.</param>
    /// <param name="destinationIndex">The starting index in the destination array, where the first <see cref="Vector3"/> should be written.</param>
    /// <param name="length">The number of normals to be transformed.</param>
    public static void TransformNormal(Vector3[] sourceArray,
        int sourceIndex,
        ref Matrix4x4 matrix,
        Vector3[] destinationArray,
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
            var normal = sourceArray[sourceIndex + x];

            destinationArray[destinationIndex + x] =
                new Vector3(
                    normal.X * matrix.M11 + normal.Y * matrix.M21 + normal.Z * matrix.M31,
                    normal.X * matrix.M12 + normal.Y * matrix.M22 + normal.Z * matrix.M32,
                    normal.X * matrix.M13 + normal.Y * matrix.M23 + normal.Z * matrix.M33);
        }
    }

    /// <summary>
    /// Apply transformation on all normals within array of <see cref="Vector3"/> by the specified <see cref="Matrix"/> and places the results in an another array.
    /// </summary>
    /// <param name="sourceArray">Source array.</param>
    /// <param name="matrix">The transformation <see cref="Matrix"/>.</param>
    /// <param name="destinationArray">Destination array.</param>
    public static void TransformNormal(Vector3[] sourceArray, ref Matrix4x4 matrix, Vector3[] destinationArray)
    {
        ArgumentNullException.ThrowIfNull(sourceArray);
        ArgumentNullException.ThrowIfNull(destinationArray);

        if (destinationArray.Length < sourceArray.Length)
            Throw.ArgumentException("Destination array length is lesser than source array length");

        for (var i = 0; i < sourceArray.Length; i++)
        {
            var normal = sourceArray[i];

            destinationArray[i] =
                new Vector3(
                    normal.X * matrix.M11 + normal.Y * matrix.M21 + normal.Z * matrix.M31,
                    normal.X * matrix.M12 + normal.Y * matrix.M22 + normal.Z * matrix.M32,
                    normal.X * matrix.M13 + normal.Y * matrix.M23 + normal.Z * matrix.M33);
        }
    }

    public static SharpDX.Vector3 AsSharpDXVector3(this ref Vector3 value) =>
        new(x: value.X, y: value.Y, z: value.Z);
}
