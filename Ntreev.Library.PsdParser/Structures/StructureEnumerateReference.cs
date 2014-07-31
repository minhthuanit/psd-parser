﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ntreev.Library.PsdParser.Structures
{
    class StructureEnumerateReference : Properties
    {
        public StructureEnumerateReference(PSDReader reader)
        {
            this.Add("Name", reader.ReadUnicodeString2());
            this.Add("ClassID", reader.ReadStringOrKey());
            this.Add("TypeID", reader.ReadStringOrKey());
            this.Add("EnumID", reader.ReadStringOrKey());
        }
    }
}