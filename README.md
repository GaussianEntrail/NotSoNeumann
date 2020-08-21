# NotSoNeumann
Console based Von Neumann neighborhood cellular automata programmed in C#

* Cells can be true or false  

* Uses a Von Neumann style neighborhood so each cell has a North (N), East (E), West (W) and South (S) neighbor (NEWS)  

* these neighbors are expressed as a four bit number- (SEWN)  

* a 16-bit "rule" is used to determine an output based on the 16 different possible neighborhoods  

# Example

* take note of the cell marked X and the cells surrounding it- . are "false" cells and O are "true" cells

>     O . . .  
>     . . . .  
>     . X O .  
>     . O . .  
>     . . O .  

* The SEWN neighborhood of this cell can be expressed as 1100 (12)  

* Let's assume the "Rule" we're using is 32000 - expressed as ‭0111110100000000‬  

* the 12th bit of this number is 1

* so in the next step, X will become 1
