﻿// Copyright (c) 2010-2014 SharpDX - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
namespace SharpDX.Direct3D12
{
    public partial class InputLayoutDescription
    {
        public InputLayoutDescription() {}

        public InputLayoutDescription(InputElement[] elements)
        {
            Elements = elements;
        }

        /// <summary>	
        /// <dd> <p> An array of <strong><see cref="SharpDX.Direct3D12.InputElement"/></strong> structures that describe the data types of the input-assembler stage. </p> </dd>	
        /// </summary>	
        /// <include file='.\..\Documentation\CodeComments.xml' path="/comments/comment[@id='D3D12_INPUT_LAYOUT_DESC::pInputElementDescs']/*"/>	
        /// <msdn-id>dn770378</msdn-id>	
        /// <unmanaged>const D3D12_INPUT_ELEMENT_DESC* pInputElementDescs</unmanaged>	
        /// <unmanaged-short>D3D12_INPUT_ELEMENT_DESC pInputElementDescs</unmanaged-short>	
        public InputElement[] Elements { get; set; }

        public static implicit operator InputLayoutDescription(InputElement[] elements)
        {
            return new InputLayoutDescription(elements);
        }
    }
}