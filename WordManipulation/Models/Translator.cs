using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WordManipulation.Interfaces;

namespace WordManipulation.Models
{
    public class Translator:ITranslator
    {
        public string ConvertMonth(int month)
        {
            if (month == 0)
            {
                return "           ";
            }
            if (month == 1)
            {
                return "Ιανουαρίου";
            }
            if (month == 2)
            {
                return "Φεβρουαρίου";
            }
            if (month == 3)
            {
                return "Μαρτίου";
            }
            if (month == 4)
            {
                return "Απριλίου";
            }
            if (month == 5)
            {
                return "Μαΐου";
            }
            if (month == 6)
            {
                return "Ιουνίου";
            }
            if (month == 7)
            {
                return "Ιουλίου";
            }
            if (month == 8)
            {
                return "Αυγούστου";
            }
            if (month == 9)
            {
                return "Σεπτεμβρίου";
            }
            if (month == 10)
            {
                return "Οκτωβρίου";
            }
            if (month == 11)
            {
                return "Νοεμβρίου";
            }
            if (month == 12)
            {
                return "Δεκεμβρίου";
            }

            return "";
        }

        public string TranslateDayOfMonth(int day)
        {
            if (day == 0)
            {
                return "        ";
            }
            if (day == 1)
            {
                return "την πρώτη";
            }
            if (day == 2)
            {
                return "στις δύο";
            }
            if (day == 3)
            {
                return "στις τρεις";
            }
            if (day == 4)
            {
                return "στις τέσσερις";
            }
            if (day == 5)
            {
                return "στις πέντε";
            }
            if (day == 6)
            {
                return "στις έξι";
            }
            if (day == 7)
            {
                return "στις επτά";
            }
            if (day == 8)
            {
                return "στις οκτώ";
            }
            if (day == 9)
            {
                return "στις εννέα";
            }
            if (day == 10)
            {
                return "στις δέκα";
            }
            if (day == 11)
            {
                return "στις έντεκα";
            }
            if (day == 12)
            {
                return "στις δώδεκα";
            }
            if (day == 13)
            {
                return "στις δεκατρείς";
            }
            if (day == 14)
            {
                return "στις δεκατέσσερις";
            }
            if (day == 15)
            {
                return "στις δεκαπέντε";
            }
            if (day == 16)
            {
                return "στις δεκαέξι";
            }
            if (day == 17)
            {
                return "στις δεκαεπτά";
            }
            if (day == 18)
            {
                return "στις δεκαοκτώ";
            }
            if (day == 19)
            {
                return "στις δεκαεννέα";
            }
            if (day == 20)
            {
                return "στις είκοσι";
            }
            if (day == 21)
            {
                return "στις εικοσιμία";
            }
            if (day == 22)
            {
                return "στις εικοσιδύο";
            }
            if (day == 23)
            {
                return "στις εικοσιτρείς";
            }
            if (day == 24)
            {
                return "στις εικοσιτέσσερις";
            }
            if (day == 25)
            {
                return "στις εικοσιπέντε";
            }
            if (day == 26)
            {
                return "στις εικοσιέξι";
            }
            if (day == 27)
            {
                return "στις εικοσιεπτά";
            }
            if (day == 28)
            {
                return "στις εικοσιοκτώ";
            }
            if (day == 29)
            {
                return "στις εικοσιεννέα";
            }
            if (day == 30)
            {
                return "στις τριάντα";
            }
            if (day == 31)
            {
                return "στις τριανταμία";
            }


            return "";
        }

        public string ConvertNameOfDay(int day)
        {
            if(day == -1)
            {
                return " ";
            }
            else if(day == 0)
            {
                return "Κυριακή";
            }
            else if (day == 1)
            {
                return "Δευτέρα";
            }
            else if (day == 2)
            {
                return "Τρίτη";
            }
            else if (day == 3)
            {
                return "Τετάρτη";
            }
            else if (day == 4)
            {
                return "Πέμπτη";
            }
            else if (day == 5)
            {
                return "Παρασκευή";
            }
            else 
            {
                return "Σάββατο";
            }
        }
    }
}