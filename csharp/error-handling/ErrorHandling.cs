﻿using System;

public static class ErrorHandling
{
    public static void HandleErrorByThrowingException() => throw new Exception();

    public static int? HandleErrorByReturningNullableType(string input) => (Int32.TryParse(input, out var i) ? i : (int?)null);

    public static bool HandleErrorWithOutParam(string input, out int result) => (Int32.TryParse(input, out result) ? true : false);

    public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableObject)
    {
        disposableObject.Dispose();
        throw new Exception();
    }
}
