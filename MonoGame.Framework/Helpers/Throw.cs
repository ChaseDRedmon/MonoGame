using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Audio;

namespace MonoGame.Framework.Utilities;

/// <summary>
/// Static Throw Helper class minimizes IL generation for method invocations during compilation, when exceptions need to be thrown
/// <remarks>https://reubenbond.github.io/posts/dotnet-perf-tuning</remarks>
/// </summary>
internal static class Throw
{
    [DoesNotReturn]
    public static void Exception(string? message = "", Exception? e = null) => throw new Exception(message, e);

    [DoesNotReturn]
    public static void NoAudioHardwareException(string? message = "", Exception? e = null) => throw new NoAudioHardwareException(message, e);

    [DoesNotReturn]
    public static void InstancePlayLimitException() => throw new InstancePlayLimitException();

    [DoesNotReturn]
    public static void NotImplementedException(string? message = "", Exception? e = null) => throw new NotImplementedException(message, e);

    [DoesNotReturn]
    public static void UnreachableException(string? message = "", Exception? e = null) => throw new UnreachableException(message, e);

    [DoesNotReturn]
    public static void IndexOutOfRangeException(string? message = "", Exception? e = null) => throw new IndexOutOfRangeException(message, e);

    [DoesNotReturn]
    public static void InvalidOperationException(string? message = "", Exception? e = null) => throw new InvalidOperationException(message, e);

    [DoesNotReturn]
    public static void NotSupportedException(string? message = "", Exception? e = null) => throw new NotSupportedException(message, e);

    [DoesNotReturn]
    public static void ArgumentOutOfRangeException() => throw new ArgumentOutOfRangeException();

    [DoesNotReturn]
    public static void ArgumentOutOfRangeException(string? message, [CallerArgumentExpression(nameof(message))] string? parameterName = "") => throw new ArgumentOutOfRangeException(parameterName, message);

    [DoesNotReturn]
    public static void ArgumentException() => throw new ArgumentException();

    [DoesNotReturn]
    public static void ArgumentException(string? message, Exception? e, [CallerArgumentExpression(nameof(message))] string? parameterName = "") => throw new ArgumentException(message, parameterName, e);

    [DoesNotReturn]
    public static void ArgumentException(string? message, [CallerArgumentExpression(nameof(message))] string? parameterName = "") => throw new ArgumentException(message, parameterName);

    [DoesNotReturn]
    public static void ArgumentNullException() => throw new ArgumentNullException();

    [DoesNotReturn]
    public static void ArgumentNullException<T>(T? argument, Exception? e, [CallerArgumentExpression(nameof(argument))] string? parameterName = "") => throw new ArgumentNullException($"Argument ({parameterName}) cannot be null", e);

    [DoesNotReturn]
    public static void ArgumentNullException<T>(T? argument, [CallerArgumentExpression(nameof(argument))] string? parameterName = "") => throw new ArgumentNullException(parameterName, "Argument cannot be null");

    [DoesNotReturn]
    public static void FileNotFoundException(string name, Exception inner) => throw new FileNotFoundException("Error loading \"" + name + "\". File not found.", inner);

    [DoesNotReturn]
    public static void ObjectDisposedException(string? message = "", Exception? e = null) => throw new ObjectDisposedException(message, e);

    [DoesNotReturn]
    public static void ObjectDisposedException<T>(T? argument, string message, [CallerArgumentExpression(nameof(argument))] string? parameterName = "") => throw new ObjectDisposedException(parameterName, message);
}
