# Anagram Creator

#### _Rearrange the letters in a word_

#### By _**Alexandra Holcombe && Katy Daviscourt**_

## Description

This web application will accept a single word from a user that it can then check against a list of other user-inputted words to see if they're anagrams of each other.  After submitting the page, the user will be given a list of the words that were anagrams.

## Setup/Installation Requirements

* Requires DNU, DNX, and Mono
* Clone to local machine
* Use command "dnu restore" in command prompt/shell
* Use command "dnx kestrel" to start server
* Navigate to http://localhost:5004 in web browser of choice

## Specifications

**The user can input any word and it will be outputted at the top of the submitted page.**
* Example Input: bananas
* Example Output: "bananas"

**The user can input a main word and a word to check against the word, and the application will output the second word if it matches the first.**
* Example Input: Main word: "team" Checker Word: "mate"
* Example Output: Main word: "team" Checker Word: "mate"

**The user can input a main word and a word to check against the word, and the application will not output the second word if it does not match.**
* Example Input: Main word: "team" Checker Word: "ring"
* Example Output: Main word: "team" "None of the given words are anagrams of 'team.'"

**The user can input a main word and a list of words and the application will output a list of words that are anagrams.**
* Example Input: Main word: "team" List: "tame, mate, meat"
* Example Output: Main word: "team" Matching List: "tame, mate, meat"

**The user can input a main word and a list of words to check, and the application will output only the words that are anagrams.**
* Example Input: Main word: "team" List: "tame, ring, phone, meat"
* Example Output: Main word: "team" Matching List: "tame, meat"

## Support and contact details

Please contact Allie Holcombe at alexandra.holcombe@gmail.com or Katy Daviscourt at katy.daviscourt@gmail.com with any questions, concerns, or suggestions.

## Technologies Used

This web application uses:
* Nancy
* Mono
* DNVM
* C#
* Razor

### License

*This project is licensed under the MIT license.*

Copyright (c) 2017 **_Alexandra Holcombe & Katy Daviscourt_**
