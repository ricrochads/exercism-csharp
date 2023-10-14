namespace ExercismCSharp;

public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        byte prefixByte;
        byte[] buffer = new byte[9];

        if (reading > uint.MaxValue)
        {
            prefixByte = 256 - sizeof(long);
            BitConverter.GetBytes(reading).CopyTo(buffer, 1);
        }
        else if (reading > int.MaxValue && reading <= uint.MaxValue)
        {
            prefixByte = sizeof(uint);
            BitConverter.GetBytes((uint)reading).CopyTo(buffer, 1);
        }
        else if (reading > ushort.MaxValue && reading <= int.MaxValue)
        {
            prefixByte = 256 - sizeof(int);
            BitConverter.GetBytes((int)reading).CopyTo(buffer, 1);
        }
        else if (reading >= 0 && reading <= ushort.MaxValue)
        {
            prefixByte = sizeof(ushort);
            BitConverter.GetBytes((ushort)reading).CopyTo(buffer, 1);
        }
        else if (reading >= short.MinValue && reading < ushort.MinValue)
        {
            prefixByte = 256 - sizeof(short);
            BitConverter.GetBytes((short)reading).CopyTo(buffer, 1);
        }
        else if (reading >= int.MinValue && reading < short.MinValue)
        {
            prefixByte = 256 - sizeof(int);
            BitConverter.GetBytes((int)reading).CopyTo(buffer, 1);
        }
        else if (reading >= long.MinValue && reading < int.MinValue)
        {
            prefixByte = 256 - sizeof(long);
            BitConverter.GetBytes(reading).CopyTo(buffer, 1);
        }
        else
        {
            prefixByte = 0;
        }

        buffer[0] = prefixByte;
        return buffer;
    }

    public static long FromBuffer(byte[] buffer)
    {
        if (buffer.Length != 9)
            return 0;

        byte prefixByte = buffer[0];

        switch (prefixByte)
        {
            case 256 - sizeof(long):
                return BitConverter.ToInt64(buffer, 1);
            case sizeof(uint):
                return BitConverter.ToUInt32(buffer, 1);
            case 256 - sizeof(int):
                return BitConverter.ToInt32(buffer, 1);
            case sizeof(ushort):
                return BitConverter.ToUInt16(buffer, 1);
            case 256 - sizeof(short):
                return BitConverter.ToInt16(buffer, 1);
            default:
                return 0;
        }
    }
}