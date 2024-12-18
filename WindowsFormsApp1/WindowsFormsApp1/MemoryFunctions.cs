using System;
using System.Runtime.InteropServices;

public static class MemoryFunctions
{
    // Definindo as funções externas para acesso ao Windows API
    [DllImport("kernel32.dll")]
    public static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, uint dwProcessId);

    [DllImport("kernel32.dll")]
    public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out uint lpNumberOfBytesRead);

    [DllImport("kernel32.dll")]
    public static extern bool CloseHandle(IntPtr hObject);

    // Constante de permissão de leitura de memória
    public const uint PROCESS_VM_READ = 0x0010;

    // Função para leitura de memória
    public static byte[] ReadMemory(IntPtr processHandle, IntPtr baseAddress, uint bufferSize)
    {
        byte[] buffer = new byte[bufferSize];
        uint bytesRead;

        bool success = ReadProcessMemory(processHandle, baseAddress, buffer, bufferSize, out bytesRead);
        if (!success || bytesRead != bufferSize)
        {
            Console.WriteLine("[-] ERROR: Failed to read {0} bytes from 0x{1:X}. ReadProcessMemory failed.", bufferSize, baseAddress);
            return null;
        }

        return buffer;
    }
}
