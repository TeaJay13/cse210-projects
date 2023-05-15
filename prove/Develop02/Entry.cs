using System;
using System.Collections.Generic;

namespace Develop02
{
    ///<summary>
    /// the resonsablity of an Entry id to store a prompt, response and date
    ///<summary>
   public class Entry
    {
        public string prompt;
        public string response;
        public string date;

        public string GetPrompt()
        {
            return prompt;
        }
        public string GetResponse()
        {
            return response;
        }
        public string GetDate()
        {
            return date;
        }
        public void StorePrompt(string prompt)
        {
            this.prompt = prompt;
        }
        public void StoreResponse(string response)
        {
            this.response = response;
        }
        public void StoreDate(string date)
        {
            this.date = date;
        }

    }

}