﻿using System.Collections.Generic;

namespace MAMMT.Helpers;

internal class HashDataContainer
{
    public List<int> Hashes = new();
    public List<short> Indices = new();
    public List<short> Offsets = new();
    public int Shift;
    public int StructSize;
}
