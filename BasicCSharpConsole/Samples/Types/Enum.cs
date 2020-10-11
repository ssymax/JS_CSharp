using System;

namespace BasicCSharpConsole.Samples.Types
{
    public enum OperationType
    {
        Add,
        Subtract,
        Divide,
        Multiply
    }

    [Flags]
    public enum FilePrivileges
    {
        Read,
        Write,
        Delete,
        Create
    }
}
