using System.Numerics;
using System.Runtime.CompilerServices;

namespace Microsoft.Xna.Framework.Helpers;

public class MatrixHelper
{
    /// <summary>
    /// Copy the values of specified <see cref="Matrix"/> to the float array.
    /// </summary>
    /// <param name="matrix">The source <see cref="Matrix"/>.</param>
    /// <returns>The array which matrix values will be stored.</returns>
    /// <remarks>
    /// Required for OpenGL 2.0 projection matrix stuff.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float[] ToFloatArray(Matrix4x4 matrix)
    {
        return new []
        {
            matrix.M11, matrix.M12, matrix.M13, matrix.M14,
            matrix.M21, matrix.M22, matrix.M23, matrix.M24,
            matrix.M31, matrix.M32, matrix.M33, matrix.M34,
            matrix.M41, matrix.M42, matrix.M43, matrix.M44
        };
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector3 Backward(ref Matrix4x4 matrix)
    {
        return new Vector3(matrix.M31, matrix.M32, matrix.M33);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Backward(ref Matrix4x4 matrix, ref Vector3 vector)
    {
        matrix.M31 = vector.X;
        matrix.M32 = vector.Y;
        matrix.M33 = vector.Z;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector3 Down(ref Matrix4x4 matrix)
    {
        return new Vector3(-matrix.M21, -matrix.M22, -matrix.M23);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Down(ref Matrix4x4 matrix, ref Vector3 vector)
    {
        matrix.M21 = -vector.X;
        matrix.M22 = -vector.Y;
        matrix.M23 = -vector.Z;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector3 Forward(ref Matrix4x4 matrix)
    {
        return new Vector3(-matrix.M31, -matrix.M32, -matrix.M33);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Forward(ref Matrix4x4 matrix, ref Vector3 vector)
    {
        matrix.M31 = -vector.X;
        matrix.M32 = -vector.Y;
        matrix.M33 = -vector.Z;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector3 Left(ref Matrix4x4 matrix)
    {
        return new Vector3(-matrix.M11, -matrix.M12, -matrix.M13);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Left(ref Matrix4x4 matrix, ref Vector3 vector)
    {
        matrix.M11 = -vector.X;
        matrix.M12 = -vector.Y;
        matrix.M13 = -vector.Z;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector3 Right(ref Matrix4x4 matrix)
    {
        return new Vector3(matrix.M11, matrix.M12, matrix.M13);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Right(ref Matrix4x4 matrix, ref Vector3 vector)
    {
        matrix.M11 = vector.X;
        matrix.M12 = vector.Y;
        matrix.M13 = vector.Z;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector3 Translation(ref Matrix4x4 matrix)
    {
        return new Vector3(matrix.M41, matrix.M42, matrix.M43);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Translation(ref Matrix4x4 matrix, ref Vector3 vector)
    {
        matrix.M41 = vector.X;
        matrix.M42 = vector.Y;
        matrix.M43 = vector.Z;
    }

    /// <summary>
    /// The upper vector formed from the second row M21, M22, M23 elements.
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector3 Up(ref Matrix4x4 matrix)
    {
        return new Vector3(matrix.M21, matrix.M22, matrix.M23);
    }

    /// <summary>
    /// The upper vector formed from the second row M21, M22, M23 elements.
    /// </summary>
    /// <param name="matrix"></param>
    /// <param name="vector"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Up(ref Matrix4x4 matrix, ref Vector3 vector)
    {
        matrix.M21 = vector.X;
        matrix.M22 = vector.Y;
        matrix.M23 = vector.Z;
    }
}
