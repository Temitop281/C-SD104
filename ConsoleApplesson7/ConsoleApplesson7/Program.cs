using System;
using System.Collections.Generic;
using System.Text;
using static Messages;

namespace ConsoleApplesson7
{
    class DatingProfile
    {
        public string firstName;
        private string lastName;
        public int age;
        public string gender;
        public string bio;
        private IEnumerable<Messages> myMessages;
        private readonly Messages message;

        //private List<Messages> myMessages;


        public DatingProfile(string firstName, string lastName, int age, string gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
            //myMessages = new List<Messages>();
           
        }

        public void WriteBio(string text)
        {
            bio = text;
        }

   


        
        public void AddToInbox(Messages message)
        {
            //myMessages.Add(message);

        }

        public void SendMessage(string messageTitle, string messageData, DatingProfile sentTo)
        {
            //Messages message = new Messages(this, messageTitle, messageData);
            sentTo.AddToInbox(message);
        }

        public void ReadMessage()
        {
            foreach (Messages message in myMessages)
            {
                if (message.isRead == false)
                {
                    Console.WriteLine(message.messageTitle);
                    Console.WriteLine(message.messageData);
                    message.isRead = true;
                }
            }
        }
    }

    public class Messages
    {
        internal bool isRead;
        internal bool messageTitle;
        internal bool messageData;
    }
}


///PART 2 Creating a message Class.


    class Messages
{
    public DatingProfile sender;
    public string messageTitle;
    public string messageData;
    public bool isRead;

    public Messages(DatingProfile sender, string messageTitle, string messageData)
    {
        this.sender = sender;
        this.messageTitle = messageTitle;
        this.messageData = messageData;
        isRead = false;
    }

    public class DatingProfile
    {
        private string v1;
        private string v2;
        private int v3;
        private string v4;

        public DatingProfile(string v1, string v2, int v3, string v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        internal void WriteBio(string v)
        {
            throw new NotImplementedException();
        }

        internal void ReadMessage()
        {
            throw new NotImplementedException();
        }

        internal void SendMessage(string v1, string v2, DatingProfile susie)
        {
            throw new NotImplementedException();
        }

        internal void ReadMessage(string v)
        {
            throw new NotImplementedException();
        }

        internal void SendMessage(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        internal void SendMessage(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }
    }
}




///Part 3: Adding Message To The List Of The Date Profile.



    class Program
{
    static void Main(string[] args)
    {
        DatingProfile brian = new DatingProfile("Brian", "White", 38, "Male");
        brian.WriteBio("Outspoken and social type");

        DatingProfile kate = new DatingProfile("Kate", "Volvo", 30, "Female");
        kate.WriteBio("I am reserve but social");

        brian.SendMessage("Hello Kate", "Can we have a nice time together tomorrow?", kate);
        kate.ReadMessage();
        kate.SendMessage("Yeah sure", "What time would that be?");
        brian.ReadMessage();
        brian.SendMessage("Ok cool", "by 05:00pm", "See you then");
    }
}





   
    



