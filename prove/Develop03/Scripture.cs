using System;
using System.Collections.Generic;
using System.IO;

namespace Develop03
{
    ///<summary>
    /// The responsibility of a Scripture is to hold scriptures.
    ///</summary>
    public class Scripture
    {
        private string _scripture = "John 3:16 | For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life";
        // private string _scripture2 = "Proverbs 5-6 | 5 Trust in the Lord with all thine heart; and lean not unto thine own understanding. 6 In all thy ways acknowledge him, and he shall direct thy paths";

        public string GetScripture()
        {
            return _scripture;
        }
    }   
    
}