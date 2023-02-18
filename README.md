# RazorLibraryProject
A fully flawed, but enthusiastic attempt to create a library website, using Asp.NET


How to run RazorLibraryProject
(and what to know)

  Running the project should be as simple as cloning it into Visual Studio via the github repository link provided. I used VS2022 to develop it, and while it has its issues, I haven't met a version of VS that wasn't... special; I'm not sure how well it will run in other versions.
  
Things to know:
The user and book lists should be populated by Bogus when the project is run, except for 2 that are hard-coded for demo purposes (librarian@library.net 
-- password (1DoesNotSimplyWalkIntoTheLibrary) and borrower@library.net (IAmBut1LowlyBorrower) -- the parentheses are part of the passwords)

When logging in as librarian, 2 new links appear in the header; Books and User Management; borrower will only see the books link.
User Management will show you a list of the users provisioned by Bogus, as well as our 2 active accounts. There is a button to create new users, but it's a trick; there are no more users to be had (through this screen; you can still register new users through the initial login/registration page, but they will have no permissions). In a previous pre-meltdown incarnation of this page, the full CRUD experience was on display here, and new users could be created with selected roles, but I couldn't quite get it back there this time. (It's back now.)

The book list has a slight variance in appearance between the 2 users.
The borrower has two options (Details and Check out). Details are simply an uneditable informtion page, and Check out... was one of my failures. (But I fixed it!)
The librarian has options for Editing, Deleting, and Checking In. Edit and Delete are exactly what you would expect, and Check In ended up just linking to the Edit page again; technically useable, but I was attempting to get something along the lines of a partial-edit endpoint set up in the controller, which might have allowed me to set up role-specific edits for librarian and borrower, but that was where my understanding of the wizardry of dependency injection failed me, I assume.(And that works too, now.)
The librarian also has a button to add more books. This button works. Why does the user admin button not work, when this one does? I asked the elders of the internet and got only riddles. (I figured out the riddles.)
