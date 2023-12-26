namespace PhoneBook
{
    public class PhoneBook
    {
        private Contact[] contacts;
        public PhoneBook()
        {
            this.contacts = new Contact[500];
        }

        public bool AddContact(string name, string phone)
        {
            int cnt = 0;
            while (this.contacts[cnt] != null && cnt < this.contacts.Length)  //Finds the first contact that is equal to null
            {
                cnt++;
            }
            if (cnt != this.contacts.Length)
            {
                this.contacts[cnt] = new Contact(name, phone);
                return true;
            }
            return false;
        }

        public bool DelContact(string name)
        {
            int cnt = 0;
            while (this.contacts[cnt] != null && cnt < this.contacts.Length)
            {
                cnt++;
            }
            if (cnt < this.contacts.Length)
            {
                this.contacts[cnt - 1] = null;
                return true;
            }
            return false;
        }

        public string GetPhone(string name)
        {
            int cnt = 0;
            while (this.contacts[cnt] != null && cnt < this.contacts.Length)
            {
                if (this.contacts[cnt].Name == name)
                {
                    return this.contacts[cnt].Phone;
                }
                cnt++;
            }
            return null;
        }

        public string[] GetAllContactsNames()
        {
            string[] tempNames = new string[this.contacts.Length];
            int cnt = 0;
            while (this.contacts[cnt] != null)
            {
                tempNames[cnt] = this.contacts[cnt].Name;
                cnt++;
            }
            string[] namesToReturn = new string[cnt];
            for (int i = 0; i < namesToReturn.Length; i++)
            {
                namesToReturn[i] = tempNames[i];
            }
            return namesToReturn;
        }
        
        public override string ToString()
        {
            string print = "";
            int cnt = 0;
            while (this.contacts[cnt] != null && cnt < this.contacts.Length)
            {
                print += $"{this.contacts[cnt].ToString()}\n";
                cnt++;
            }
            return print;
        }

    }
}
