using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ReadOrWriteAddressBook_UsingFileIO
{
    public class FileIOStream
    {
        public static void ReadFilestream()
        {
            string path = @"D:\RFP\AddressBook_FileIO\ReadOrWriteAddressBook_UsingFileIO\ReadOrWriteAddressBook_UsingFileIO\ContactList.txt";
            if (File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                        Console.WriteLine(line); ;
                }
            }
            else
                Console.WriteLine("File not found");
        }
        public static void WriteFileStream(AddressBook addressBook)
        {
            string path = @"D:\RFP\AddressBook_FileIO\ReadOrWriteAddressBook_UsingFileIO\ReadOrWriteAddressBook_UsingFileIO\ContactList.txt";
            if (File.Exists(path))
            {
                using (StreamWriter sr = File.AppendText(path))
                {
                    //Writes the entered string into the file
                    sr.Write("\nCONTACT DETAILS IN ADDRESSBOOK: {0}=>\n", addressBook.addressBookName);
                    for (int i = 0; i < addressBook.contactList.Count; i++)
                    {
                        string line = "\n" + (i + 1) + ".\tFullName: " + addressBook.contactList[i].firstName + " " + addressBook.contactList[i].lastName + "\n\tAddress: " + addressBook.contactList[i].address + "\n\tCity: " + addressBook.contactList[i].city + "\n\tState: " + addressBook.contactList[i].state + "\n\tZip: " + addressBook.contactList[i].zip + "\n\tPhoneNumber: " + addressBook.contactList[i].phoneNumber + "\n\tEmail: " + addressBook.contactList[i].email + "\n";
                        sr.Write(line);
                    }
                }
            }
            ReadFilestream();
        }
    }
}
