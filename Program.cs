/*
 * Author: Daniela Lopez
 * Course: COMP003A
 * Purpose: final prjoect intake form code 
 */ 

 namespace COMP003A.Assignment1
 {
 using System.Text.RegularExpressions;
 class Program
 {
 static void Main (string[]args)
 {
 Console.WriteLine ("".PadRight(18, '-'));
 Console.WriteLine ("Client Intake Form");
 Console.WriteLine ("".PadRight(18, '-'));

 Console.WriteLine("What is your first name: ");
 string first = Console.ReadLine ();
 if (IsValidName(first))
 {
    Console.WriteLine ("");
 }
 else
 {
    Console.WriteLine ("Invalid name");
 }  

 Console.WriteLine ("What is your last name: ");
 string last = Console.ReadLine ();
 if (IsValidLast(last))
 {
    Console.WriteLine ("");
 }
 else 
 {
    Console.WriteLine ("Invalid Name");
 }

 Console.WriteLine ("What year were you born: ");
 string year = Console.ReadLine ();
 int yearBorn = 2023 - Convert.ToInt32 (year);
 if (ValidYear(year))
 {
    Console.WriteLine ("");
 }
 else 
 {
    Console.WriteLine ("Invalid year");
 }

 Console.WriteLine ("Gender: Male, Female, or Other ");
 string gender = Console.ReadLine ();
 if (ValidGender(gender))
 {
    Console.WriteLine ("");
 }
 else 
 {
    Console.WriteLine ("Invalid input");
 }

 Console.WriteLine ("Primary Adress:");
 string adress = Console.ReadLine (); 
 if (IsValidAdress(adress))
 {
    Console.WriteLine ("");
 }
 else 
 {
    Console.WriteLine ("Invalid adress");
 }

 Console.WriteLine ("\nCity: ");
 string city = Console.ReadLine ();
 if (IsValidCity(city))
 {
    Console.WriteLine ("");
 }
 else 
 {
    Console.WriteLine ("Invalid input");
 }

 Console.WriteLine ("\nState: ");
 string state = Console.ReadLine ();
 if (IsValidState(state))
 {
    Console.WriteLine ("");
 }
 else 
 {
    Console.WriteLine ("Invalid input");
 }

 Console.WriteLine ("\nZip: ");
 string zip = Console.ReadLine ();
 if (IsValidZip(zip))
 {
    Console.WriteLine ("");
 }
 else 
 {
    Console.WriteLine ("Invalid zip code");
 }

 Console.WriteLine ("\nCell Phone Number: ");
 string cell = Console.ReadLine ();
 if (IsValidCell(cell))
 {
    Console.WriteLine ("");
 }
 else 
 {
    Console.WriteLine ("Invalid input");
 }

 Console.WriteLine ("\nOccupation: ");
 string occupation = Console.ReadLine ();
 if (IsValidOccupation(occupation))
 {
    Console.WriteLine ("");
 }
 else 
 {
    Console.WriteLine ("Invalid input");
 }

 Console.WriteLine ("\nEducation/Degree(s) Obtained: ");
 string education = Console.ReadLine ();
 if (IsValidEducation(education))
 {
    Console.WriteLine ("");
 }
 else 
 {
    Console.WriteLine ("Invalid input");
 }

 Console.WriteLine ("\nName of person to contact in an emergency: ");
 string emergency = Console.ReadLine ();
 if (IsValidEmergency(emergency))
 {
    Console.WriteLine ("");
 }
 else 
 {
    Console.WriteLine ("Invalid input");
 }

 Console.WriteLine ("\nRelationship:");
 string relationship = Console.ReadLine ();
 if (IsValidRelationship(relationship))
 {
    Console.WriteLine ("");
 }
 else 
 {
    Console.WriteLine ("Invalid input");
 }

 Console.WriteLine ("\nContact Phone Number:");
 string contact = Console.ReadLine ();
 if (IsValidContact(contact))
 {
    Console.WriteLine ("");
 }
 else 
 {
    Console.WriteLine ("Invalid input");
 }

 List<String> userList = new List<String>();
 userList.Add (adress);
 userList.Add (city);
 userList.Add (state);
 userList.Add (zip);
 userList.Add (cell);
 userList.Add (occupation);
 userList.Add (education);
 userList.Add (emergency);
 userList.Add (relationship);
 userList.Add (contact);

 Console.WriteLine ($"Hello {first} {last}!");
 Console.WriteLine ($"You are {yearBorn} years old.");
 Console.WriteLine ($"You identify as {gender}");

 foreach (var user in userList)
 {
    Console.WriteLine (user);
 }

 }

/// <summary> Validation Methods </summary>
/// <param name="first"> alphabetic input </param>
 static bool IsValidName (string first)
 {
 string pattern = @"[a-zA-Z]+";
 if (Regex.IsMatch(first, pattern))
 {
    return true;
 }
 else
 {
    return false;
 }
 }

/// <param name="last"> alphabetic input </param>
 static bool IsValidLast (string last)
 {
 string pattern = @"[a-zA-Z]+";
 if (Regex.IsMatch(last, pattern))
 {
    return true;
 }
 else
 {
    return false;
 }
 }

/// <param name="year"> numeric input </param>
 static bool ValidYear (string year)
 {
 string pattern = @"19[0-9]{2}|20[01][0-9]|202[0-3]";
 if (Regex.IsMatch(year, pattern))
 {
    return true;
 }
 else
 {
    return false;
 }
 }
/// <param name="gender"> input for gender string </param>
 static bool ValidGender (string gender)
 {
 string pattern = @"(?:male|Male|Female|female|MALE|FEMALE|other|Other|OTHER)$";
 if (Regex.IsMatch(gender, pattern))
 {
    return true;
 }
 else
 {
    return false;
 }
 }

/// <param name="adress"> alphanumeric input </param>
 static bool IsValidAdress (string adress)
 {
 string pattern = @"[a-zA-Z,0-9]";
 if (Regex.IsMatch(adress, pattern))
 {
    return true;
 }
 else
 {
    return false;
 }
 }

/// <param name="first"> alphabetic input </param>
 static bool IsValidCity (string city)
 {
 string pattern = @"[a-zA-Z]";
 if (Regex.IsMatch(city, pattern))
 {
    return true;
 }
 else
 {
    return false;
 }
 }

/// <param name="first"> alphabetic input </param>
 static bool IsValidState (string state)
 {
 string pattern = @"[a-zA-Z]";
 if (Regex.IsMatch(state, pattern))
 {
    return true;
 }
 else
 {
    return false;
 }
 }

/// <param name="first"> numeric input </param>
 static bool IsValidZip (string zip)
 {
 string pattern = @"[0-9]";
 if (Regex.IsMatch(zip, pattern))
 {
    return true;
 }
 else
 {
    return false;
 }
 }

/// <param name="first"> numeric & character input for cell phone string</param>
 static bool IsValidCell (string cell)
 {
 string pattern = @"[0-9,-]";
 if (Regex.IsMatch(cell, pattern))
 {
    return true;
 }
 else
 {
    return false;
 }
 }
/// <param name="first"> alphanumeric input </param>
 static bool IsValidOccupation (string occupation)
 {
 string pattern = @"[a-zA-Z,0-9]";
 if (Regex.IsMatch(occupation, pattern))
 {
    return true;
 }
 else
 {
    return false;
 }
 }

/// <param name="first"> alphanumeric input </param>
 static bool IsValidEducation (string education)
 {
 string pattern = @"[a-zA-Z,0-9]";
 if (Regex.IsMatch(education, pattern))
 {
    return true;
 }
 else
 {
    return false;
 }
 }
  /// <param name="first"> alphabetic input </param>
 static bool IsValidEmergency (string emergency)
 {
 string pattern = @"[a-zA-Z]";
 if (Regex.IsMatch(emergency, pattern))
 {
    return true;
 }
 else
 {
    return false;
 }
 }

 /// <param name="first"> alphabetic input </param>
 static bool IsValidRelationship (string relationship)
 {
 string pattern = @"[a-zA-Z]";
 if (Regex.IsMatch(relationship, pattern))
 {
    return true;
 }
 else
 {
    return false;
 }
 }
/// <param name="first"> numeric & character input contact string</param>
 static bool IsValidContact (string contact)
 {
 string pattern = @"[0-9,-]";
 if (Regex.IsMatch(contact, pattern))
 {
    return true;
 }
 else
 {
    return false;
 }
 }


}
}