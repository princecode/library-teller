using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            //set the rental dates for each type via a static field
                //implement

            //create a list a propulate it with the date in our file
            FileIO getFile = new FileIO();

            //populate mediaToRent with the values returned from getFile instead of an empty list e.g. "new List<string>();"
            //implement-D
            List<string> mediaToRent = getFile.ReturnMediaFile(@"..\..\media.txt");

            //create a new list for us to use to store our media objects to rent
            List <Media> rentedMedia = new List<Media>();

            //for each line from the rental 
            foreach(string s in mediaToRent)
            {
                //match each needed component
                //populae with your regex to match the format


                Match match = Regex.Match(s, @"^Type: \s*([a-zA-z]+),Title: \s*(.*)+,Length: \s*([0-9a-z a-z]+)$", RegexOptions.IgnoreCase);
                // more efficient class example: ^Type:\s*(.*),Title:\s*(.*),Length:
                if (match.Success)
                {
                    //populate each component with the values from your capture groups
                    string type = match.Groups[1].ToString();
                    string title = match.Groups[2].ToString();
                    string length = match.Groups[3].ToString();

                    //using the components we got figure out which type of object we should create and insert
                    if (type.Equals("Book"))
                    {
                        //create a book object
                        Book newBook = new Book();
                        //populate the book object with a title and length
                        newBook.Title = title;
                        //then add the newly created book to rentedMedia
                        rentedMedia.Add(newBook);

                    }
                    //complete for the DVD and Magazine media types
                    //implement-D
                    if (type.Equals("DvD"))
                    {
                        //create a dvd object
                        DVD newDVD = new DVD();
                        //populate the dvd object with a title and length
                        newDVD.Title = title;
                        //then add the newly created dvd to rentedMedia
                        rentedMedia.Add(newDVD);

                    }

                    if (type.Equals("Magazine"))
                    {
                        //create a dvd object
                        Magazine newMagazine = new Magazine();
                        //populate the dvd object with a title and length
                        newMagazine.Title = title;
                        //then add the newly created dvd to rentedMedia
                        rentedMedia.Add(newMagazine);

                    }




                }
            }

            //for each media item we have in the list print the details for each
            foreach (Media mediaItem in rentedMedia)
            {
                //for each mediaItem call PrintMediaDetails()
                //implement
                mediaItem.PrintMediaDetails();

            }

            //halt the program so we can read the output
            Console.ReadKey();
        }
    }
}
