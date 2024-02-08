﻿You work for the World war museum and you’ve found thousands of Morse coded documents.

The Morse is a Code composed of dot and lines representing the alphabet letters. Here comes the transcription of the Morse alphabet. 

A: .-
B: -...
C: -.-.
D: -..
E: .
F: ..-.
G: --.
H: ....
I: ..
J: .---
K: -.-
L: .-..
M: --
N: -.
O: ---
P: .--.
Q: --.-
R: .-.
S: ...
T: -
U: ..-
V: ...-
W: .--
X: -..-
Y: -.--
Z: --..

In the documents you received, there are no spaces characters to separate the letters from the words. So a decoded sentence could have different interpretations. 

A human can understand how to cut the words because of its knowledge of the language. For solving this with a computer, you’ll need a dictionary of existing human words (you’ll find a dictionary for solving this game in the joined file). 
Even with a dictionary, a Morse sequence can have different human sentences.

You’re mission is to write the function able to find all the possible human solutions for a given Morse Sentence (For a given Morse sentence, you have to return each combination of possible human words of the dictionary with no dot or line remaining …)

The function or class should take different parameters:

*	the dictionary as a list of the possible human words (1000 more frequent English words provided)
*	the Morse sentence to solve

Return: a list of possible human sentences

The sentence you’ve to solve is: “--.--.---.......-.---.-.-.-..-.....--..-....-.-----..-”

Please send us your code and the list of solutions you’ve found.