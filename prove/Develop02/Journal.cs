    using System;
    using System.Collections.Generic;

    namespace Develop02
    {
        ///<summary>
        /// the resonsablity of an Journal is to hold entries.
        ///<summary>
        public class Journal
        {
            public List<Entry> entries;

            public Journal()
            {
                entries = new List<Entry>();
            }
            public List<Entry> GetEntries()
            {
                return entries;
            }

            public void StoreEntry(Entry entry)
            {
                if (!entries.Contains(entry))
                {
                    entries.Add(entry);
                }
            }

        }
        
    }