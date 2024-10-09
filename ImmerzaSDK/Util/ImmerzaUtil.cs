using System;
using System.Buffers.Binary;
using UnityEngine;

namespace ImmerzaSDK.Util
{
    internal class ImmerzaUtil
    {
        public static string GetHierarchyPath(GameObject obj)
        {
            string path = "/" + obj.name;
            while (obj.transform.parent != null)
            {
                obj = obj.transform.parent.gameObject;
                path = "/" + obj.name + path;
            }

            return path;
        }

        public static void PrecomputeHashTable()
        {
            const uint polynomial = 0xEDB88320;
            for (uint i = 0; i < 256; i++)
            {
                uint crc = i;
                for (uint j = 8; j > 0; j--)
                {
                    if ((crc & 1) == 1)
                    {
                        crc = (crc >> 1) ^ polynomial;
                    }
                    else
                    {
                        crc >>= 1;
                    }
                }
                Crc32Table[i] = crc;
            }
        }

        public static uint CalculateCrc32(ReadOnlySpan<byte> data, uint crc)
        {
            for (int i = 0; i < data.Length; i++)
            {
                byte index = (byte)((crc & 0xFF) ^ data[i]);
                crc = (crc >> 8) ^ Crc32Table[index];
            }
            return crc;
        }

        static readonly uint[] Crc32Table = new uint[256];
    }
}
