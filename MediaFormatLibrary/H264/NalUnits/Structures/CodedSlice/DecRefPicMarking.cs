/* Copyright (C) 2014-2015 Tal Aloni <tal.aloni.il@gmail.com>. All rights reserved.
 * 
 * You can redistribute this program and/or modify it under the terms of
 * the GNU Lesser Public License as published by the Free Software Foundation,
 * either version 3 of the License, or (at your option) any later version.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace MediaFormatLibrary.H264
{
    /// <summary>
    /// dec_ref_pic_marking
    /// </summary>
    public class DecRefPicMarking
    {
        public DecRefPicMarking()
        {
        }

        public DecRefPicMarking(RawBitStream bitStream)
        {
            throw new NotImplementedException();
        }

        public void WriteBits(RawBitStream bitStream)
        {
            throw new NotImplementedException();
        }
    }
}
