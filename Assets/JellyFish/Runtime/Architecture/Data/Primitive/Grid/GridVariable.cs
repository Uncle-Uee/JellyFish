﻿/*
 *
 * Created By: Ubaidullah Effendi-Emjedi
 * Alias: Uee
 * Modified By:  
 *
 * Last Modified: 09 November 2019
 *
 * License:

MIT License

Copyright (c) 2018 Ubaidullah Effendi-Emjedi

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

 *
 */

using UnityEngine;

// ReSharper disable once CheckNamespace
namespace JellyFish.Data.Primitive
{
    [CreateAssetMenu(menuName = "JellyFish/Data/Primitive/Grid", fileName = "Grid")]
    public class GridVariable : ScriptableObject
    {
#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        public Grid Value;

        public void SetValue(Grid value)
        {
            Value = value;
        }

        public void SetValue(GridVariable value)
        {
            Value = value.Value;
        }
    }
}