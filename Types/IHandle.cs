﻿namespace HorizonPDFAPI
{
    public interface IHandle<T>
    {
        bool IsNull { get; }

        T SetToNull();
    }
}