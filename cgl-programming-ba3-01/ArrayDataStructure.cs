﻿using System;

namespace cgl_programming_ba3_01
{
    internal class ArrayDataStructure : DataStructure
    {
        private string[] _data = null;

        public ArrayDataStructure(string firstEntry)
        {
            _data = new string[] { firstEntry };
        }

        public override void AddEntryAtEnd(string entry)
        {
            Array.Resize(ref _data, _data.Length + 1);

            _data[_data.Length - 1] = entry;
        }

        public override void AddEntryAtIndex(int index, string entry)
        {
            Array.Resize(ref _data, _data.Length + 1);

            // Increments the index of each object in the array with a given or higher index.
            for (int i = _data.Length - 2; i >= index ; i--)
            {
                _data[i + 1] = _data[i];
            }

            _data[index] = entry;
        }

        public override string GetEntryAtIndex(int index)
        {
            throw new NotImplementedException();
        }

        public override void RemoveEntryAtIndex(int index)
        {
            throw new NotImplementedException();
        }

        public override string ListAllEntries()
        {
            var output = "";

            foreach (var entry in _data)
            {
                output += entry + ", ";
            }

            return output;
        }
    }
}