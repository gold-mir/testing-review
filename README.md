## Specifications
* RepeatCounter class has a method CheckEqual which checks whether two input strings are the same word.
    * Example Input: "Kitten", "Kitten"
        * Expected Output: True
    * Example Input: "Kitten", "Puppy"
        * Expected Output: False
    * Using simple one-word inputs for these tests ensures that there won't be complications caused by multi-word strings.
* CheckEqual ignores capitalization
    * Example Input: "kitten", "KIttEn"
        * Expected Output: True
    * Reusing the same word from the first test with punctuation means that we're testing something we already know passes test 1.
* CheckEqual method ignores non letter characters
    * Example Input: "Kitten!", "Kitten."
        * Expected Output: True
    * Again reusing "kitten" as test word
* CheckEqual returns false for non-legal inputs such as a word with no letter characters or an empty string
    * Example Input: "", ""
        * Expected Output: False
    * Example Input: "....1234", "....1234"
        * Expected Output: False
    * Testing strings against themselves to ensure that the CheckEqual method does not register them as the same word, since they are not words.
* RepeatCounter has a GetWordCount method which splits a given sentence into space-separated words, then runs CheckEqual on each of those words against another input word, and returns the number of times the input word occurs in the given sentence.
    * Example Input: "I have three cute kittens. Kittens are totally adorable!", "kittens"
        * Expected Output: 2
    * Testing a sentence that should also be compliant with other CheckEqual tests ensures that nothing breaks between the two methods.
* GetWordCount returns -1 if either input contains no letter characters or is empty.
    * Example Input: "1 2 3+45 1 16", "1"
        * Expected Output: -1
    * As before, testing with a string that *does* contain another string ensures that the method is properly returning -1 even if the first string does contain the second.
