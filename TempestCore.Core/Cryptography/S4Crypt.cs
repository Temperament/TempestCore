﻿namespace TempestCore.Core.Cryptography
{
    public static class S4Crypt
    {
        #region Key
        private static readonly byte[] KeyTable = // actually we just need 40 bytes
        { 
            0x82, 0x53, 0x43, 0x4C, 0x2B, 0x0D, 0x37, 0xD7, 0xD9, 0xD8,
            0x1B, 0x6D, 0xA0, 0xC3, 0x2B, 0xEE, 0x45, 0x88, 0x1A, 0xA6,
            0x18, 0x1D, 0x9D, 0x38, 0x2A, 0x55, 0x03, 0x1D, 0xCD, 0xA6,
            0x73, 0x07, 0xED, 0x8D, 0xC5, 0xDB, 0xA3, 0xBD, 0xB6, 0xD5,
            0x34, 0xB5, 0xB2, 0x3D, 0x7D, 0x43, 0x8C, 0xC0, 0x21, 0x25,
            0xCD, 0xB6, 0x53, 0x76, 0xCE, 0x5D, 0xD4, 0x87, 0xCA, 0x84,
            0x81, 0xCB, 0x5E, 0x04, 0xBA, 0x69, 0x3E, 0x65, 0xDE, 0x21,
            0x8A, 0x63, 0x62, 0x71, 0x90, 0x87, 0x0A, 0x52, 0x28, 0x44,
            0xA3, 0x49, 0xDC, 0xEA, 0x09, 0xB7, 0x01, 0xA4, 0xA1, 0x11,
            0x11, 0x8E, 0x80, 0x35, 0x5B, 0xDD, 0x38, 0xD5, 0x4E, 0x36,
            0x0C, 0xA2, 0xBB, 0x05, 0x36, 0x57, 0x2E, 0x98, 0xBE, 0x88,
	        0x3C, 0x28, 0x43, 0x63, 0xA0, 0xE9, 0xE1, 0x6D, 0x51, 0xCB,
	        0x4D, 0x62, 0x84, 0x43, 0x89, 0xC7, 0x89, 0x83, 0x65, 0x29,
	        0x53, 0x95, 0x7C, 0xC0, 0xA1, 0x0C, 0xDB, 0xD7, 0x04, 0xD8,
	        0x6A, 0xD1, 0x73, 0x1D, 0x21, 0x67, 0x86, 0x8D, 0xA4, 0xA0,
	        0x34, 0xBD, 0x31, 0x20, 0x61, 0x0E, 0xE9, 0x63, 0xB4, 0xC0,
	        0xC7, 0x36, 0x1B, 0x41, 0x23, 0x9C, 0xD1, 0x8C, 0x25, 0x53,
	        0x42, 0x2E, 0x45, 0x6D, 0x42, 0x7B, 0x4E, 0x5B, 0xEB, 0x24,
	        0x33, 0x74, 0x52, 0x28, 0xC6, 0x2A, 0xC3, 0x16, 0x60, 0xA5,
	        0x45, 0x35, 0xDB, 0x9A, 0x54, 0x97, 0xE2, 0xEE, 0x9B, 0xDE,
	        0xE0, 0xC3, 0x84, 0x41, 0xED, 0x45, 0x4C, 0x69, 0xD9, 0x28,
	        0x55, 0x27, 0x8E, 0x3A, 0x3C, 0x8E, 0x84, 0x97, 0x14, 0xE6,
	        0x58, 0x51, 0x26, 0x0D, 0xE2, 0x9E, 0x66, 0x7C, 0x0D, 0x01,
	        0x7D, 0x17, 0x4C, 0x08, 0xDD, 0x97, 0x1C, 0x7B, 0xCE, 0x5D,
	        0x54, 0x37, 0x7C, 0x0C, 0x8E, 0x27, 0x7A, 0x78, 0x2E, 0xE6,
	        0x6D, 0x25, 0x62, 0x62, 0x98, 0x20, 0x2E, 0x23, 0x15, 0x61,
	        0x7D, 0x97, 0x50, 0x07, 0x20, 0x7A, 0x04, 0x29, 0x62, 0x90,
	        0x6B, 0xE9, 0xE6, 0x22, 0x72, 0x38, 0x56, 0xC9, 0x06, 0x2E,
	        0x3B, 0x47, 0x08, 0x2D, 0x21, 0x42, 0x07, 0x69, 0x4A, 0x57,
	        0x8B, 0x79, 0xE7, 0x56, 0x27, 0x23, 0x24, 0x85, 0x47, 0x74,
	        0x75, 0x85, 0xA9, 0xEB, 0x10, 0xCB, 0x17, 0x85, 0x4B, 0x5E,
	        0x20, 0x78, 0xD0, 0x7D, 0x86, 0x5E, 0x14, 0x7E, 0x64, 0x50,
	        0x69, 0x52, 0x4A, 0xBD, 0x8C, 0x9B, 0xD6, 0x63, 0xBD, 0x26,
	        0x86, 0x32, 0x95, 0xA4, 0x02, 0x9B, 0x01, 0x14, 0x49, 0x78,
	        0x88, 0x57, 0x3A, 0x01, 0x4A, 0xBC, 0x50, 0xCD, 0x31, 0x39,
	        0x71, 0x30, 0x5B, 0x9C, 0x4D, 0x21, 0x67, 0x82, 0xE8, 0x5C,
	        0x66, 0x10, 0xA9, 0x7D, 0xD2, 0x36, 0xE2, 0xB1, 0x28, 0x20,
	        0xD5, 0xE7, 0xD5, 0x0E, 0xD4, 0x0C, 0x2C, 0x77, 0x80, 0x0E,
	        0xA6, 0x37, 0xBE, 0x61, 0xAD, 0xD6, 0x17, 0x65, 0x13, 0x70,
	        0xAE, 0x40, 0x3B, 0x52, 0xEE, 0x53, 0x84, 0xEB, 0x04, 0x0D,
	        0x49, 0x8C, 0x77, 0xC0, 0xC0, 0x64, 0x54, 0x0B, 0x22, 0xBD,
	        0x82, 0x93, 0x9A, 0x23, 0x8D, 0xE4, 0xC8, 0x9D, 0xB3, 0x50,
	        0x44, 0xB1, 0xE2, 0x9E, 0x15, 0x7A, 0xA1, 0x0C, 0x24, 0xE3,
	        0x1E, 0x0A, 0x0A, 0x73, 0x6A, 0xA5, 0x8B, 0x3A, 0x53, 0x33,
	        0xB0, 0xE6, 0xB7, 0x51, 0x70, 0xDA, 0xD6, 0x29, 0xAA, 0x10,
	        0xB5, 0x8A, 0x38, 0x37, 0x4E, 0x7A, 0x3B, 0x74, 0x7B, 0x63,
	        0x41, 0x7C, 0x21, 0x65, 0x5E, 0x26, 0x95, 0x44, 0x75, 0xA3,
	        0x74, 0xDD, 0xB4, 0x33, 0x9E, 0x54, 0x3C, 0x95, 0x5E, 0x34,
	        0x10, 0x19, 0x43, 0x64, 0x78, 0x2B, 0xA6, 0x60, 0x7D, 0xCD,
	        0xA9, 0x28, 0xB8, 0x85, 0x0E, 0x66, 0xC7, 0x3C, 0x28, 0xDC,
	        0xA1, 0x4D, 0x60, 0x9B, 0xC7, 0xD3, 0x74, 0x93, 0xE6, 0xC3,
	        0x97, 0x76, 0x12, 0xA4, 0xCB, 0xB9, 0x22, 0x51, 0xB9, 0x79,
	        0x5C, 0x68, 0xDB, 0xE6, 0x59, 0x57, 0x95, 0xCD, 0xAE, 0xCA,
	        0x67, 0xB8, 0x37, 0x90, 0xBA, 0x54, 0x98, 0x95, 0x73, 0x8E,
	        0x47, 0xC1, 0x40, 0xBA, 0x80, 0x26, 0x10, 0xAA, 0x60, 0x64,
	        0xD8, 0x69, 0xC7, 0x0D, 0x2B, 0x28, 0xA6, 0xBA, 0x01, 0x4A,
	        0xEE, 0x28, 0x65, 0xC4, 0x9D, 0x41, 0x8D, 0x91, 0x6C, 0x91,
	        0x7E, 0x80, 0xC3, 0xD1, 0xAE, 0xB6, 0x92, 0x41, 0x66, 0x13,
	        0x72, 0x20, 0x26, 0xA1, 0x72, 0x05, 0x29, 0x08, 0x88, 0x30,
	        0x40, 0x6D, 0x5A, 0x41, 0x01, 0x7A, 0xDB, 0x2C, 0xEE, 0xC3,
	        0x5C, 0x03, 0x38, 0xD8, 0x95, 0xE7, 0xB4, 0x67, 0x30, 0x51,
	        0x21, 0x68, 0x78, 0x89, 0x68, 0x0B, 0xE3, 0xB0, 0x28, 0xB3,
	        0xA9, 0x38, 0x18, 0xE4, 0x59, 0x43, 0xC9, 0x52, 0x75, 0x04,
	        0x15, 0x07, 0x97, 0x14, 0x07, 0x27, 0xDA, 0xE5, 0xD9, 0xDB,
	        0xDB, 0x08, 0x27, 0xA3, 0x64, 0xDC, 0x42, 0xE3, 0x3D, 0x0D,
	        0x26, 0xA2, 0xC3, 0x5E, 0x3E, 0xA7, 0x47, 0xE4, 0x1C, 0x73,
	        0x13, 0x99, 0x9E, 0xBA, 0xD3, 0x08, 0x73, 0x88, 0x03, 0x01,
	        0x24, 0x2E, 0x09, 0xBD, 0x3A, 0x6E, 0x3C, 0xB6, 0xA2, 0x22,
	        0xE7, 0x27, 0x60, 0x20, 0x85, 0xDA, 0xEA, 0x84, 0x86, 0x41,
	        0x67, 0x1C, 0x83, 0xBE, 0x7A, 0x61, 0x67, 0x01, 0x18, 0x30,
	        0xC6, 0x37, 0xBC, 0x51, 0xBC, 0x78, 0xA1, 0x53, 0x53, 0x58,
	        0x9B, 0x32, 0x05, 0x67, 0x6B, 0xC7, 0x3A, 0x7C, 0xA8, 0xE5,
	        0x70, 0x10, 0x29, 0x88, 0x94, 0xC0, 0xEE, 0x8D, 0x52, 0x20,
	        0xD9, 0xC3, 0x3C, 0xB3, 0x43, 0x74, 0x83, 0xC8, 0xC5, 0xAA,
	        0x90, 0x58, 0x0C, 0xD0, 0xBC, 0x2A, 0xED, 0x04, 0x05, 0x8E,
	        0x27, 0xDE, 0x9C, 0x37, 0x57, 0x2A, 0x93, 0x63, 0x1B, 0x9E,
	        0xC3, 0x52, 0xDB, 0xE9, 0x63, 0x9A, 0x87, 0x18, 0x6D, 0xBE,
	        0x1B, 0x37, 0x6A, 0xEA, 0x01, 0x02, 0x01, 0xB5, 0x74, 0x71,
	        0xA5, 0x9A, 0x9A, 0x3A, 0x11, 0x8B, 0x62, 0xD7, 0xB0, 0x06,
	        0x0C, 0xA0, 0x10, 0x09, 0x97, 0x5A, 0xEB, 0xEA, 0x18, 0xB8
        };
        #endregion

        public static void Decrypt(byte[] data, int offset = 0)
        {
            for (var i = offset; i < data.Length; i++)
            {
                var j = i - offset;
                data[i] = (byte)(((data[i] >> 1) & 0x7F) | (((data[i]) & 1) << 7) & 0x80);
                data[i] ^= KeyTable[j % 40];
            }
        }

        //public static void Encrypt(byte[] data, int offset = 0)
        //{
        //    for (var i = offset; i < data.Length; i++)
        //    {
        //        var j = i - offset;
        //        data[i] ^= KeyTable[j % 40];
        //        data[i] = (byte)((((data[i] & 0x80) >> 7) & 1) | (((data[i]) << 1) & 0xFE));
        //    }
        //}
    }
}
