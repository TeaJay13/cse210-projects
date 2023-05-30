using System;
using System.Collections.Generic;
using System.IO;

namespace Develop03
{
    ///<summary>
    /// The responsibility of a Refrence is find the refrence from the scripture text.
    ///</summary>
    public class Reference
    {
        Scripture text = new Scripture();
        string fullText;
        string[] textParts;

        string _reference;

        public Reference()
        {
            fullText = text.GetScripture();
        }

        public string SplitReference()
        {
            textParts = fullText.Split("|");
           
           return textParts[0];
        }
        public string GetRefrence()
        {
            _reference = SplitReference();
            return _reference;
        }
    }
}