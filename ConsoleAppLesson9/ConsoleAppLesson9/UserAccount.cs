using System;

namespace ConsoleAppLesson9
{
    internal class UserAccount
    {
        private string v1;
        private string v2;

        public UserAccount(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        internal void Login(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        internal void GetUserInfo()
        {
            throw new NotImplementedException();
        }
    }
}