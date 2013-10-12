ConvAdapt
=========

A program to conventionalize simple files.
WARNING: The programme is still experimental. Use at your own risk!


Example:
You have an language file and the variable names don't use the same name convention. Instead of doing it completey manually you can use ConvAdapt.

Our language file:
movesuccess = "The file movement was successfull";
Abort = "abort";
old_pass = "Current password";
New_Pass = "New password";
New_Pass_repeat = "Repeat new password";

Now we need to analyze the regex pattern of the variable hence the program knows which words it should change. The pattern is built up of 3 groups: start, obj and end. The obj group must contain the pattern for the words which shall change.

In our example we want change all words before the equals sign. The regex pattern looks because of that like this: (?<obj>.*)(?<end>\s*=\s*".*";)

We don't need the start group. The start and end groups are both optional. Sometimes you need only the start group and so on.

I want to conventionalize all names to underscore case with no underscore at start, lowered text and a capitalized first letter. Don't forget to activate the search filter. :)
Then click on apply convention and you get the changed text.

If you want to replace files you need to use the Files tab.
