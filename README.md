# Address Book
##### By Adam Titus

### Details
A website where you may store peoples names addresses and phone numbers server side.

### Installation Instructions
* Copy this url `https://github.com/TheBigTaco/CSharp-Address-Book`
* Open your Shell program of choice, such as gitbash or terminal.
* Navigate with your shell to the location you would like to save this project.
* Once there, type the command `git clone` then paste the url you copied above and hit enter
* Now navigate to this folder that you cloned by typing `cd CSharp-Address-Book`.
* Once in, type in your shell `dotnet restore` and wait for the files to be decompressed and loaded.
* Now that that's done, type `dotnet run`.
* Open your web browser and navigate too `http://localhost:5000/`

### Contact Information
You can reach me at adamtitus76@gmail.com or connect with me on linkedin at `www.linkedin.com/in/adam-titus-06740b149`
## Specs
|behavior|input|output|
|-|-|-|
|Will Accept new Contacts|Adam 500 fakestreet 406-555-555|Adam 500 fakestreet 406-555-555|
|Will let you see details of individual contacts| Adam | Adam 500 fakestreet 406-555-555|
|Will Display Contacts in a list|Adam| Adam, Michael, Chris, Rane|
|Will let you delete individual contacts| Adam| Michael, Chris, Rane|
|Will let you clear your contacts| Clear| You have cleared your contacts|
|Will let you search your contacts by name| h | Michael, Chris|
|Will let you search your contacts by address| 500 fake| Adam|
|Will let you search your contacts by phone number| 555 | Adam|


#### Legal
Licensed under the MIT License

Copyright (c) 2017 Adam Titus All Rights Reserved.

_If you find a way to monetize this please contact the author_
