# NotSoNeumann
Console based Von Neumann neighborhood cellular automata programmed in C#

* Cells can be true or false  

* Uses a Von Neumann style neighborhood so each cell has a North (N), East (E), West (W) and South (S) neighbor (NEWS)  

* these neighbors are expressed as a four bit number- NEWS.  

* Since each cell is a binary value, there are 16 possible NEWS neighborhoods 

* a 16-bit "rule" is used to determine an output based on the 16 different possible NEWS neighborhoods  

# Example

* take note of the cell marked X and the cells surrounding it- . are "false" cells and O are "true" cells

>     O . . .  
>     . . . .  
>     . X O .  
>     . O . .  
>     . . O .  

* The NEWS neighborhood of this cell can be expressed as 0101 (5)  

* Let's assume the "Rule" we're using is 32000 - this can be expressed in binary as ‭0111110100000000‬  

* the 12th bit of this number is 0

* so in the next step, X will become 0
