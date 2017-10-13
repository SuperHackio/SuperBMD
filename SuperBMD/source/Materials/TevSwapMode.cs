﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameFormatReader.Common;

namespace SuperBMD.Materials
{
    public class TevSwapMode
    {
        public byte RasSel;
        public byte TexSel;

        public TevSwapMode(EndianBinaryReader reader)
        {
            RasSel = reader.ReadByte();
            TexSel = reader.ReadByte();
            reader.SkipInt16();
        }
    }
}
