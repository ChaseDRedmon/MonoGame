using System;
using System.Numerics;
using MonoGame.Framework.Utilities;

namespace Microsoft.Xna.Framework;

public static class Vector4Helper
{
    /// <summary>
    /// Creates a new <see cref="Vector4"/> that contains the cartesian coordinates of a vector specified in barycentric coordinates and relative to 4d-triangle.
    /// </summary>
    /// <param name="value1">The first vector of 4d-triangle.</param>
    /// <param name="value2">The second vector of 4d-triangle.</param>
    /// <param name="value3">The third vector of 4d-triangle.</param>
    /// <param name="amount1">Barycentric scalar <c>b2</c> which represents a weighting factor towards second vector of 4d-triangle.</param>
    /// <param name="amount2">Barycentric scalar <c>b3</c> which represents a weighting factor towards third vector of 4d-triangle.</param>
    /// <returns>The cartesian translation of barycentric coordinates.</returns>
    public static Vector4 Barycentric(Vector4 value1, Vector4 value2, Vector4 value3, float amount1, float amount2)
    {
        return new Vector4(
            MathHelper.Barycentric(value1.X, value2.X, value3.X, amount1, amount2),
            MathHelper.Barycentric(value1.Y, value2.Y, value3.Y, amount1, amount2),
            MathHelper.Barycentric(value1.Z, value2.Z, value3.Z, amount1, amount2),
            MathHelper.Barycentric(value1.W, value2.W, value3.W, amount1, amount2));
    }

    /// <summary>
    /// Creates a new <see cref="Vector4"/> that contains the cartesian coordinates of a vector specified in barycentric coordinates and relative to 4d-triangle.
    /// </summary>
    /// <param name="value1">The first vector of 4d-triangle.</param>
    /// <param name="value2">The second vector of 4d-triangle.</param>
    /// <param name="value3">The third vector of 4d-triangle.</param>
    /// <param name="amount1">Barycentric scalar <c>b2</c> which represents a weighting factor towards second vector of 4d-triangle.</param>
    /// <param name="amount2">Barycentric scalar <c>b3</c> which represents a weighting factor towards third vector of 4d-triangle.</param>
    /// <param name="result">The cartesian translation of barycentric coordinates as an output parameter.</param>
    public static void Barycentric(ref Vector4 value1, ref Vector4 value2, ref Vector4 value3, float amount1,
        float amount2, out Vector4 result)
    {
        result.X = MathHelper.Barycentric(value1.X, value2.X, value3.X, amount1, amount2);
        result.Y = MathHelper.Barycentric(value1.Y, value2.Y, value3.Y, amount1, amount2);
        result.Z = MathHelper.Barycentric(value1.Z, value2.Z, value3.Z, amount1, amount2);
        result.W = MathHelper.Barycentric(value1.W, value2.W, value3.W, amount1, amount2);
    }

    /// <summary>
    /// Creates a new <see cref="Vector4"/> that contains CatmullRom interpolation of the specified vectors.
    /// </summary>
    /// <param name="value1">The first vector in interpolation.</param>
    /// <param name="value2">The second vector in interpolation.</param>
    /// <param name="value3">The third vector in interpolation.</param>
    /// <param name="value4">The fourth vector in interpolation.</param>
    /// <param name="amount">Weighting factor.</param>
    /// <returns>The result of CatmullRom interpolation.</returns>
    public static Vector4 CatmullRom(Vector4 value1, Vector4 value2, Vector4 value3, Vector4 value4, float amount)
    {
        return new Vector4(
            MathHelper.CatmullRom(value1.X, value2.X, value3.X, value4.X, amount),
            MathHelper.CatmullRom(value1.Y, value2.Y, value3.Y, value4.Y, amount),
            MathHelper.CatmullRom(value1.Z, value2.Z, value3.Z, value4.Z, amount),
            MathHelper.CatmullRom(value1.W, value2.W, value3.W, value4.W, amount));
    }

    /// <summary>
    /// Creates a new <see cref="Vector4"/> that contains CatmullRom interpolation of the specified vectors.
    /// </summary>
    /// <param name="value1">The first vector in interpolation.</param>
    /// <param name="value2">The second vector in interpolation.</param>
    /// <param name="value3">The third vector in interpolation.</param>
    /// <param name="value4">The fourth vector in interpolation.</param>
    /// <param name="amount">Weighting factor.</param>
    /// <param name="result">The result of CatmullRom interpolation as an output parameter.</param>
    public static void CatmullRom(ref Vector4 value1, ref Vector4 value2, ref Vector4 value3, ref Vector4 value4,
        float amount, out Vector4 result)
    {
        result.X = MathHelper.CatmullRom(value1.X, value2.X, value3.X, value4.X, amount);
        result.Y = MathHelper.CatmullRom(value1.Y, value2.Y, value3.Y, value4.Y, amount);
        result.Z = MathHelper.CatmullRom(value1.Z, value2.Z, value3.Z, value4.Z, amount);
        result.W = MathHelper.CatmullRom(value1.W, value2.W, value3.W, value4.W, amount);
    }

    /// <summary>
    /// Round the members of this <see cref="Vector4"/> towards positive infinity.
    /// </summary>
    public static void Ceiling(this ref Vector4 vector)
    {
        vector.X = MathF.Ceiling(vector.X);
        vector.Y = MathF.Ceiling(vector.Y);
        vector.Z = MathF.Ceiling(vector.Z);
        vector.W = MathF.Ceiling(vector.W);
    }

    /// <summary>
    /// Creates a new <see cref="Vector4"/> that contains members from another vector rounded towards positive infinity.
    /// </summary>
    /// <param name="value">Source <see cref="Vector4"/>.</param>
    /// <returns>The rounded <see cref="Vector4"/>.</returns>
    public static Vector4 Ceiling(Vector4 value)
    {
        value.X = MathF.Ceiling(value.X);
        value.Y = MathF.Ceiling(value.Y);
        value.Z = MathF.Ceiling(value.Z);
        value.W = MathF.Ceiling(value.W);
        return value;
    }

    /// <summary>
    /// Creates a new <see cref="Vector4"/> that contains members from another vector rounded towards positive infinity.
    /// </summary>
    /// <param name="value">Source <see cref="Vector4"/>.</param>
    /// <param name="result">The rounded <see cref="Vector4"/>.</param>
    public static void Ceiling(ref Vector4 value, out Vector4 result)
    {
        result.X = MathF.Ceiling(value.X);
        result.Y = MathF.Ceiling(value.Y);
        result.Z = MathF.Ceiling(value.Z);
        result.W = MathF.Ceiling(value.W);
    }

    /// <summary>
    /// Round the members of this <see cref="Vector4"/> towards negative infinity.
    /// </summary>
    public static void Floor(this ref Vector4 vector)
    {
        vector.X = MathF.Floor(vector.X);
        vector.Y = MathF.Floor(vector.Y);
        vector.Z = MathF.Floor(vector.Z);
        vector.W = MathF.Floor(vector.W);
    }

    /// <summary>
    /// Creates a new <see cref="Vector4"/> that contains members from another vector rounded towards negative infinity.
    /// </summary>
    /// <param name="value">Source <see cref="Vector4"/>.</param>
    /// <returns>The rounded <see cref="Vector4"/>.</returns>
    public static Vector4 Floor(Vector4 value)
    {
        value.X = MathF.Floor(value.X);
        value.Y = MathF.Floor(value.Y);
        value.Z = MathF.Floor(value.Z);
        value.W = MathF.Floor(value.W);
        return value;
    }

    /// <summary>
    /// Creates a new <see cref="Vector4"/> that contains members from another vector rounded towards negative infinity.
    /// </summary>
    /// <param name="value">Source <see cref="Vector4"/>.</param>
    /// <param name="result">The rounded <see cref="Vector4"/>.</param>
    public static void Floor(ref Vector4 value, out Vector4 result)
    {
        result.X = MathF.Floor(value.X);
        result.Y = MathF.Floor(value.Y);
        result.Z = MathF.Floor(value.Z);
        result.W = MathF.Floor(value.W);
    }

    /// <summary>
    /// Creates a new <see cref="Vector4"/> that contains hermite spline interpolation.
    /// </summary>
    /// <param name="value1">The first position vector.</param>
    /// <param name="tangent1">The first tangent vector.</param>
    /// <param name="value2">The second position vector.</param>
    /// <param name="tangent2">The second tangent vector.</param>
    /// <param name="amount">Weighting factor.</param>
    /// <returns>The hermite spline interpolation vector.</returns>
    public static Vector4 Hermite(Vector4 value1, Vector4 tangent1, Vector4 value2, Vector4 tangent2, float amount)
    {
        return new Vector4(MathHelper.Hermite(value1.X, tangent1.X, value2.X, tangent2.X, amount),
            MathHelper.Hermite(value1.Y, tangent1.Y, value2.Y, tangent2.Y, amount),
            MathHelper.Hermite(value1.Z, tangent1.Z, value2.Z, tangent2.Z, amount),
            MathHelper.Hermite(value1.W, tangent1.W, value2.W, tangent2.W, amount));
    }

    /// <summary>
    /// Creates a new <see cref="Vector4"/> that contains hermite spline interpolation.
    /// </summary>
    /// <param name="value1">The first position vector.</param>
    /// <param name="tangent1">The first tangent vector.</param>
    /// <param name="value2">The second position vector.</param>
    /// <param name="tangent2">The second tangent vector.</param>
    /// <param name="amount">Weighting factor.</param>
    /// <param name="result">The hermite spline interpolation vector as an output parameter.</param>
    public static void Hermite(ref Vector4 value1, ref Vector4 tangent1, ref Vector4 value2, ref Vector4 tangent2,
        float amount, out Vector4 result)
    {
        result.W = MathHelper.Hermite(value1.W, tangent1.W, value2.W, tangent2.W, amount);
        result.X = MathHelper.Hermite(value1.X, tangent1.X, value2.X, tangent2.X, amount);
        result.Y = MathHelper.Hermite(value1.Y, tangent1.Y, value2.Y, tangent2.Y, amount);
        result.Z = MathHelper.Hermite(value1.Z, tangent1.Z, value2.Z, tangent2.Z, amount);
    }

    /// <summary>
    /// Creates a new <see cref="Vector4"/> that contains linear interpolation of the specified vectors.
    /// Uses <see cref="MathHelper.LerpPrecise"/> on MathHelper for the interpolation.
    /// Less efficient but more precise compared to <see cref="Vector4.Lerp(Vector4, Vector4, float)"/>.
    /// See remarks section of <see cref="MathHelper.LerpPrecise"/> on MathHelper for more info.
    /// </summary>
    /// <param name="value1">The first vector.</param>
    /// <param name="value2">The second vector.</param>
    /// <param name="amount">Weighting value(between 0.0 and 1.0).</param>
    /// <returns>The result of linear interpolation of the specified vectors.</returns>
    public static Vector4 LerpPrecise(Vector4 value1, Vector4 value2, float amount)
    {
        return new Vector4(
            MathHelper.LerpPrecise(value1.X, value2.X, amount),
            MathHelper.LerpPrecise(value1.Y, value2.Y, amount),
            MathHelper.LerpPrecise(value1.Z, value2.Z, amount),
            MathHelper.LerpPrecise(value1.W, value2.W, amount));
    }

    /// <summary>
    /// Creates a new <see cref="Vector4"/> that contains linear interpolation of the specified vectors.
    /// Uses <see cref="MathHelper.LerpPrecise"/> on MathHelper for the interpolation.
    /// Less efficient but more precise compared to <see cref="Vector4.Lerp(ref Vector4, ref Vector4, float, out Vector4)"/>.
    /// See remarks section of <see cref="MathHelper.LerpPrecise"/> on MathHelper for more info.
    /// </summary>
    /// <param name="value1">The first vector.</param>
    /// <param name="value2">The second vector.</param>
    /// <param name="amount">Weighting value(between 0.0 and 1.0).</param>
    /// <param name="result">The result of linear interpolation of the specified vectors as an output parameter.</param>
    public static void LerpPrecise(ref Vector4 value1, ref Vector4 value2, float amount, out Vector4 result)
    {
        result.X = MathHelper.LerpPrecise(value1.X, value2.X, amount);
        result.Y = MathHelper.LerpPrecise(value1.Y, value2.Y, amount);
        result.Z = MathHelper.LerpPrecise(value1.Z, value2.Z, amount);
        result.W = MathHelper.LerpPrecise(value1.W, value2.W, amount);
    }

    /// <summary>
    /// Round the members of this <see cref="Vector4"/> to the nearest integer value.
    /// </summary>
    public static void Round(this ref Vector4 vector)
    {
        vector.X = MathF.Round(vector.X);
        vector.Y = MathF.Round(vector.Y);
        vector.Z = MathF.Round(vector.Z);
        vector.W = MathF.Round(vector.W);
    }

    /// <summary>
    /// Creates a new <see cref="Vector4"/> that contains members from another vector rounded to the nearest integer value.
    /// </summary>
    /// <param name="value">Source <see cref="Vector4"/>.</param>
    /// <returns>The rounded <see cref="Vector4"/>.</returns>
    public static Vector4 Round(Vector4 value)
    {
        value.X = MathF.Round(value.X);
        value.Y = MathF.Round(value.Y);
        value.Z = MathF.Round(value.Z);
        value.W = MathF.Round(value.W);
        return value;
    }

    /// <summary>
    /// Creates a new <see cref="Vector4"/> that contains members from another vector rounded to the nearest integer value.
    /// </summary>
    /// <param name="value">Source <see cref="Vector4"/>.</param>
    /// <param name="result">The rounded <see cref="Vector4"/>.</param>
    public static void Round(ref Vector4 value, out Vector4 result)
    {
        result.X = MathF.Round(value.X);
        result.Y = MathF.Round(value.Y);
        result.Z = MathF.Round(value.Z);
        result.W = MathF.Round(value.W);
    }

    /// <summary>
    /// Creates a new <see cref="Vector4"/> that contains cubic interpolation of the specified vectors.
    /// </summary>
    /// <param name="value1">Source <see cref="Vector4"/>.</param>
    /// <param name="value2">Source <see cref="Vector4"/>.</param>
    /// <param name="amount">Weighting value.</param>
    /// <returns>Cubic interpolation of the specified vectors.</returns>
    public static Vector4 SmoothStep(Vector4 value1, Vector4 value2, float amount)
    {
        return new Vector4(
            MathHelper.SmoothStep(value1.X, value2.X, amount),
            MathHelper.SmoothStep(value1.Y, value2.Y, amount),
            MathHelper.SmoothStep(value1.Z, value2.Z, amount),
            MathHelper.SmoothStep(value1.W, value2.W, amount));
    }

    /// <summary>
    /// Creates a new <see cref="Vector4"/> that contains cubic interpolation of the specified vectors.
    /// </summary>
    /// <param name="value1">Source <see cref="Vector4"/>.</param>
    /// <param name="value2">Source <see cref="Vector4"/>.</param>
    /// <param name="amount">Weighting value.</param>
    /// <param name="result">Cubic interpolation of the specified vectors as an output parameter.</param>
    public static void SmoothStep(ref Vector4 value1, ref Vector4 value2, float amount, out Vector4 result)
    {
        result.X = MathHelper.SmoothStep(value1.X, value2.X, amount);
        result.Y = MathHelper.SmoothStep(value1.Y, value2.Y, amount);
        result.Z = MathHelper.SmoothStep(value1.Z, value2.Z, amount);
        result.W = MathHelper.SmoothStep(value1.W, value2.W, amount);
    }

    /// <summary>
    /// Apply transformation on vectors within array of <see cref="Vector4"/> by the specified <see cref="Matrix"/> and places the results in an another array.
    /// </summary>
    /// <param name="sourceArray">Source array.</param>
    /// <param name="sourceIndex">The starting index of transformation in the source array.</param>
    /// <param name="matrix">The transformation <see cref="Matrix"/>.</param>
    /// <param name="destinationArray">Destination array.</param>
    /// <param name="destinationIndex">The starting index in the destination array, where the first <see cref="Vector4"/> should be written.</param>
    /// <param name="length">The number of vectors to be transformed.</param>
    public static void Transform
    (
        Vector4[] sourceArray,
        int sourceIndex,
        ref Matrix4x4 matrix,
        Vector4[] destinationArray,
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
            var value = sourceArray[sourceIndex + i];
            destinationArray[destinationIndex + i] = Vector4.Transform(value, matrix);
        }
    }

    /// <summary>
    /// Apply transformation on vectors within array of <see cref="Vector4"/> by the specified <see cref="Quaternion"/> and places the results in an another array.
    /// </summary>
    /// <param name="sourceArray">Source array.</param>
    /// <param name="sourceIndex">The starting index of transformation in the source array.</param>
    /// <param name="rotation">The <see cref="Quaternion"/> which contains rotation transformation.</param>
    /// <param name="destinationArray">Destination array.</param>
    /// <param name="destinationIndex">The starting index in the destination array, where the first <see cref="Vector4"/> should be written.</param>
    /// <param name="length">The number of vectors to be transformed.</param>
    public static void Transform(
        Vector4[] sourceArray,
        int sourceIndex,
        ref Quaternion rotation,
        Vector4[] destinationArray,
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
            var value = sourceArray[sourceIndex + i];
            destinationArray[destinationIndex + i] = Vector4.Transform(value, rotation);
        }
    }

    /// <summary>
    /// Apply transformation on all vectors within array of <see cref="Vector4"/> by the specified <see cref="Matrix"/> and places the results in an another array.
    /// </summary>
    /// <param name="sourceArray">Source array.</param>
    /// <param name="matrix">The transformation <see cref="Matrix"/>.</param>
    /// <param name="destinationArray">Destination array.</param>
    public static void Transform(Vector4[] sourceArray, ref Matrix4x4 matrix, Vector4[] destinationArray)
    {
        ArgumentNullException.ThrowIfNull(sourceArray);
        ArgumentNullException.ThrowIfNull(destinationArray);

        if (destinationArray.Length < sourceArray.Length)
            Throw.ArgumentException("Destination array length is lesser than source array length");

        for (var i = 0; i < sourceArray.Length; i++)
        {
            var value = sourceArray[i];
            destinationArray[i] = Vector4.Transform(value, matrix);
        }
    }

    /// <summary>
    /// Apply transformation on all vectors within array of <see cref="Vector4"/> by the specified <see cref="Quaternion"/> and places the results in an another array.
    /// </summary>
    /// <param name="sourceArray">Source array.</param>
    /// <param name="rotation">The <see cref="Quaternion"/> which contains rotation transformation.</param>
    /// <param name="destinationArray">Destination array.</param>
    public static void Transform(Vector4[] sourceArray, ref Quaternion rotation, Vector4[] destinationArray)
    {
        ArgumentNullException.ThrowIfNull(sourceArray);
        ArgumentNullException.ThrowIfNull(destinationArray);

        if (destinationArray.Length < sourceArray.Length)
            Throw.ArgumentException("Destination array length is lesser than source array length");

        for (var i = 0; i < sourceArray.Length; i++)
        {
            var value = sourceArray[i];
            destinationArray[i] = Vector4.Transform(value, rotation);
        }
    }

    public static SharpDX.Vector4 AsSharpDXVector4(this ref Vector4 value) =>
        new(x: value.X, y: value.Y, z: value.Z, w: value.W);

    public static SharpDX.Vector4 AsSharpDXVector4(this ref Color color) =>
        new SharpDX.Vector4(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f, color.A / 255.0f);
}
